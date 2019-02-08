namespace MJ12
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.targetProcess = new System.Windows.Forms.GroupBox();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.processList = new System.Windows.Forms.ComboBox();
            this.settingsBox = new System.Windows.Forms.GroupBox();
            this.injectBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.asmFilePath = new System.Windows.Forms.TextBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.namespaceBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.classBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.methodBox = new System.Windows.Forms.TextBox();
            this.callbackHide = new System.Windows.Forms.CheckBox();
            this.assemblyHide = new System.Windows.Forms.CheckBox();
            this.targetProcess.SuspendLayout();
            this.settingsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // targetProcess
            // 
            this.targetProcess.Controls.Add(this.refreshBtn);
            this.targetProcess.Controls.Add(this.processList);
            this.targetProcess.Location = new System.Drawing.Point(14, 14);
            this.targetProcess.Name = "targetProcess";
            this.targetProcess.Size = new System.Drawing.Size(417, 71);
            this.targetProcess.TabIndex = 0;
            this.targetProcess.TabStop = false;
            this.targetProcess.Text = "Target Process";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(277, 28);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(97, 21);
            this.refreshBtn.TabIndex = 1;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // processList
            // 
            this.processList.FormattingEnabled = true;
            this.processList.Location = new System.Drawing.Point(21, 28);
            this.processList.Name = "processList";
            this.processList.Size = new System.Drawing.Size(235, 21);
            this.processList.TabIndex = 0;
            this.processList.SelectedIndexChanged += new System.EventHandler(this.processList_SelectedIndexChanged);
            // 
            // settingsBox
            // 
            this.settingsBox.Controls.Add(this.assemblyHide);
            this.settingsBox.Controls.Add(this.callbackHide);
            this.settingsBox.Controls.Add(this.methodBox);
            this.settingsBox.Controls.Add(this.label4);
            this.settingsBox.Controls.Add(this.classBox);
            this.settingsBox.Controls.Add(this.label3);
            this.settingsBox.Controls.Add(this.namespaceBox);
            this.settingsBox.Controls.Add(this.label2);
            this.settingsBox.Controls.Add(this.browseBtn);
            this.settingsBox.Controls.Add(this.asmFilePath);
            this.settingsBox.Controls.Add(this.label1);
            this.settingsBox.Location = new System.Drawing.Point(16, 96);
            this.settingsBox.Name = "settingsBox";
            this.settingsBox.Size = new System.Drawing.Size(413, 185);
            this.settingsBox.TabIndex = 1;
            this.settingsBox.TabStop = false;
            this.settingsBox.Text = "Settings";
            // 
            // injectBtn
            // 
            this.injectBtn.Enabled = false;
            this.injectBtn.Location = new System.Drawing.Point(16, 287);
            this.injectBtn.Name = "injectBtn";
            this.injectBtn.Size = new System.Drawing.Size(413, 71);
            this.injectBtn.TabIndex = 2;
            this.injectBtn.Text = "Injection";
            this.injectBtn.UseVisualStyleBackColor = true;
            this.injectBtn.Click += new System.EventHandler(this.injectBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assembly:";
            // 
            // asmFilePath
            // 
            this.asmFilePath.Location = new System.Drawing.Point(113, 26);
            this.asmFilePath.Name = "asmFilePath";
            this.asmFilePath.ReadOnly = true;
            this.asmFilePath.Size = new System.Drawing.Size(179, 20);
            this.asmFilePath.TabIndex = 1;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(308, 26);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(97, 21);
            this.browseBtn.TabIndex = 2;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Namespace:";
            // 
            // namespaceBox
            // 
            this.namespaceBox.Location = new System.Drawing.Point(113, 56);
            this.namespaceBox.Name = "namespaceBox";
            this.namespaceBox.Size = new System.Drawing.Size(179, 20);
            this.namespaceBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Class:";
            // 
            // classBox
            // 
            this.classBox.Location = new System.Drawing.Point(113, 83);
            this.classBox.Name = "classBox";
            this.classBox.Size = new System.Drawing.Size(179, 20);
            this.classBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Method:";
            // 
            // methodBox
            // 
            this.methodBox.Location = new System.Drawing.Point(113, 112);
            this.methodBox.Name = "methodBox";
            this.methodBox.Size = new System.Drawing.Size(179, 20);
            this.methodBox.TabIndex = 8;
            // 
            // callbackHide
            // 
            this.callbackHide.AutoSize = true;
            this.callbackHide.Location = new System.Drawing.Point(19, 152);
            this.callbackHide.Name = "callbackHide";
            this.callbackHide.Size = new System.Drawing.Size(119, 17);
            this.callbackHide.TabIndex = 9;
            this.callbackHide.Text = "Hide from callbacks";
            this.callbackHide.UseVisualStyleBackColor = true;
            // 
            // assemblyHide
            // 
            this.assemblyHide.AutoSize = true;
            this.assemblyHide.Location = new System.Drawing.Point(144, 152);
            this.assemblyHide.Name = "assemblyHide";
            this.assemblyHide.Size = new System.Drawing.Size(125, 17);
            this.assemblyHide.TabIndex = 10;
            this.assemblyHide.Text = "Hide from assemblies";
            this.assemblyHide.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 372);
            this.Controls.Add(this.injectBtn);
            this.Controls.Add(this.settingsBox);
            this.Controls.Add(this.targetProcess);
            this.Name = "Main";
            this.Text = "MJ12 - Private Mono Injector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.targetProcess.ResumeLayout(false);
            this.settingsBox.ResumeLayout(false);
            this.settingsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox targetProcess;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.ComboBox processList;
        private System.Windows.Forms.GroupBox settingsBox;
        private System.Windows.Forms.Button injectBtn;
        private System.Windows.Forms.TextBox classBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox namespaceBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.TextBox asmFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox assemblyHide;
        private System.Windows.Forms.CheckBox callbackHide;
        private System.Windows.Forms.TextBox methodBox;
        private System.Windows.Forms.Label label4;
    }
}

