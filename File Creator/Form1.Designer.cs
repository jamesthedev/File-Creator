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
            this.cboExtensions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileCreatorTooltips = new System.Windows.Forms.ToolTip(this.components);
            this.chkBoilerplate = new System.Windows.Forms.CheckBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnSelect = new System.Windows.Forms.Button();
            this.chkFileGroup = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.chkOpenFiles = new System.Windows.Forms.CheckBox();
            this.txtMessages = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(34, 44);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(293, 27);
            this.txtFileName.TabIndex = 1;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(30, 20);
            this.lblFileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(90, 20);
            this.lblFileName.TabIndex = 2;
            this.lblFileName.Text = "File Name:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(359, 82);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 4;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.MintCream;
            this.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.btnGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(34, 322);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(191, 68);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Create &File";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(34, 401);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(191, 30);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "&Clear All Fields";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(30, 185);
            this.lblPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(80, 20);
            this.lblPath.TabIndex = 7;
            this.lblPath.Text = "File Path:";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilePath.Location = new System.Drawing.Point(34, 209);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(540, 27);
            this.txtFilePath.TabIndex = 5;
            // 
            // cboExtensions
            // 
            this.cboExtensions.DropDownHeight = 105;
            this.cboExtensions.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboExtensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboExtensions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboExtensions.FormattingEnabled = true;
            this.cboExtensions.IntegralHeight = false;
            this.cboExtensions.Items.AddRange(new object[] {
            "c",
            "cs",
            "css",
            "docx",
            "html",
            "java",
            "js ",
            "php",
            "pptx",
            "xml"});
            this.cboExtensions.Location = new System.Drawing.Point(34, 128);
            this.cboExtensions.Name = "cboExtensions";
            this.cboExtensions.Size = new System.Drawing.Size(235, 28);
            this.cboExtensions.Sorted = true;
            this.cboExtensions.TabIndex = 2;
            this.cboExtensions.SelectedIndexChanged += new System.EventHandler(this.cboExtensions_SelectedIndexChanged);
            this.cboExtensions.TextUpdate += new System.EventHandler(this.cboExtensions_TextUpdate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Extension:";
            // 
            // chkBoilerplate
            // 
            this.chkBoilerplate.AutoSize = true;
            this.chkBoilerplate.Enabled = false;
            this.chkBoilerplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoilerplate.Location = new System.Drawing.Point(298, 130);
            this.chkBoilerplate.Name = "chkBoilerplate";
            this.chkBoilerplate.Size = new System.Drawing.Size(169, 24);
            this.chkBoilerplate.TabIndex = 3;
            this.chkBoilerplate.Text = "Include &Boilerplate";
            this.chkBoilerplate.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnSelect
            // 
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(594, 210);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(94, 27);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "&Select...";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // chkFileGroup
            // 
            this.chkFileGroup.AutoSize = true;
            this.chkFileGroup.Enabled = false;
            this.chkFileGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFileGroup.Location = new System.Drawing.Point(487, 130);
            this.chkFileGroup.Name = "chkFileGroup";
            this.chkFileGroup.Size = new System.Drawing.Size(164, 24);
            this.chkFileGroup.TabIndex = 4;
            this.chkFileGroup.Text = "Create File &Group";
            this.chkFileGroup.UseVisualStyleBackColor = true;
            this.chkFileGroup.CheckedChanged += new System.EventHandler(this.chkFileGroup_CheckedChanged);
            // 
            // chkOpenFiles
            // 
            this.chkOpenFiles.AutoSize = true;
            this.chkOpenFiles.Checked = true;
            this.chkOpenFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOpenFiles.Location = new System.Drawing.Point(34, 294);
            this.chkOpenFiles.Name = "chkOpenFiles";
            this.chkOpenFiles.Size = new System.Drawing.Size(195, 21);
            this.chkOpenFiles.TabIndex = 8;
            this.chkOpenFiles.Text = "&Open File When Complete";
            this.chkOpenFiles.UseVisualStyleBackColor = true;
            // 
            // txtMessages
            // 
            this.txtMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessages.Location = new System.Drawing.Point(298, 322);
            this.txtMessages.Multiline = true;
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.ReadOnly = true;
            this.txtMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessages.Size = new System.Drawing.Size(390, 111);
            this.txtMessages.TabIndex = 11;
            // 
            // frmFileCreator
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 473);
            this.Controls.Add(this.txtMessages);
            this.Controls.Add(this.chkOpenFiles);
            this.Controls.Add(this.chkFileGroup);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.chkBoilerplate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboExtensions);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.txtFileName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmFileCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Creator";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
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
        private System.Windows.Forms.ComboBox cboExtensions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip fileCreatorTooltips;
        private System.Windows.Forms.CheckBox chkBoilerplate;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.CheckBox chkFileGroup;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox chkOpenFiles;
        private System.Windows.Forms.TextBox txtMessages;
    }
}

