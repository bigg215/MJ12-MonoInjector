using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace MJ12
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            RefreshMonoProcess();
            Text += !Environment.Is64BitProcess ? " (x86)" : " (x64)";
        }

        private void RefreshMonoProcess()
        {
            processList.Items.Clear();
            settingsBox.Enabled = false;
            injectBtn.Enabled = false;

            foreach(Process process in Process.GetProcesses())
            {
                try
                {
                    foreach (ProcessModule module in process.Modules)
                    {
                        if (module.FileName.Contains("mono.dll"))
                        {
                            processList.Items.Add(new PrintableProcess(process));
                        }
                    }
                }
                catch { }
            }

            if(processList.Items.Count > 0)
            {
                processList.SelectedIndex = 0;
            }
        }

        private void processList_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool flag = (processList.SelectedItem != null && processList.SelectedItem is PrintableProcess);
            settingsBox.Enabled = flag;
            injectBtn.Enabled = flag && !string.IsNullOrEmpty(asmFilePath.Text);
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshMonoProcess();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            asmFilePath.Text = "";
            injectBtn.Enabled = false;

            using (OpenFileDialog file = new OpenFileDialog())
            {
                file.Filter = "DLL Files|*.dll";

                if (file.ShowDialog() == DialogResult.OK)
                {
                    asmFilePath.Text = file.FileName;
                    injectBtn.Enabled = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void injectBtn_Click(object sender, EventArgs e)
        {
            PrintableProcess printableProcess = processList.SelectedItem as PrintableProcess;

            MonoInjector.Settings injectionSettings = new MonoInjector.Settings
            {
                AssemblyBytes = File.ReadAllBytes(asmFilePath.Text),
                Namespace = namespaceBox.Text,
                ClassName = classBox.Text,
                MethodName = methodBox.Text,
                HideAssemblyLoad = assemblyHide.Checked,
            };

            if (MonoInjector.Inject(printableProcess.InternalProcess, injectionSettings))
            {
                MessageBox.Show("Injection was successful!");
            } else
            {
                MessageBox.Show("An error occured while injecting...");

                asmFilePath.Text = "";
                namespaceBox.Text = "";
                classBox.Text = "";
                methodBox.Text = "";
                RefreshMonoProcess();
            }
        }
    }
}
