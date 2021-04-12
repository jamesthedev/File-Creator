namespace File_Creator
{
    partial class frmFileCreator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFileCreator));
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.cboExtensions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.extensionsTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.chkBoilerplate = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(119, 14);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(175, 22);
            this.txtFileName.TabIndex = 1;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(16, 19);
            this.lblFileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(75, 17);
            this.lblFileName.TabIndex = 2;
            this.lblFileName.Text = "File Name:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(356, 74);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 4;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(13, 268);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(140, 30);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "&Generate File";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(230, 268);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "&Clear Fields";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(16, 189);
            this.lblPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(67, 17);
            this.lblPath.TabIndex = 7;
            this.lblPath.Text = "File Path:";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(119, 184);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(329, 22);
            this.txtFilePath.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(348, 268);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cboExtensions
            // 
            this.cboExtensions.DropDownHeight = 105;
            this.cboExtensions.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboExtensions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboExtensions.FormattingEnabled = true;
            this.cboExtensions.IntegralHeight = false;
            this.cboExtensions.Items.AddRange(new object[] {
            "c",
            "cs",
            "css",
            "html",
            "java",
            "js ",
            "php"});
            this.cboExtensions.Location = new System.Drawing.Point(119, 90);
            this.cboExtensions.Name = "cboExtensions";
            this.cboExtensions.Size = new System.Drawing.Size(175, 24);
            this.cboExtensions.Sorted = true;
            this.cboExtensions.TabIndex = 2;
            this.cboExtensions.SelectedIndexChanged += new System.EventHandler(this.cboExtensions_SelectedIndexChanged);
            this.cboExtensions.TextUpdate += new System.EventHandler(this.cboExtensions_TextUpdate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Extension:";
            // 
            // chkBoilerplate
            // 
            this.chkBoilerplate.AutoSize = true;
            this.chkBoilerplate.Enabled = false;
            this.chkBoilerplate.Location = new System.Drawing.Point(119, 120);
            this.chkBoilerplate.Name = "chkBoilerplate";
            this.chkBoilerplate.Size = new System.Drawing.Size(146, 21);
            this.chkBoilerplate.TabIndex = 3;
            this.chkBoilerplate.Text = "Include &Boilerplate";
            this.chkBoilerplate.UseVisualStyleBackColor = true;
            this.chkBoilerplate.Visible = false;
            // 
            // frmFileCreator
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(464, 308);
            this.Controls.Add(this.chkBoilerplate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboExtensions);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.txtFileName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFileCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cboExtensions;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolTip extensionsTooltip;
        private System.Windows.Forms.CheckBox chkBoilerplate;
    }
}

