using System;
using System.Windows.Forms;
using System.IO;
using File_Creator.boilerplate;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace File_Creator
{
    public partial class frmFileCreator : Form
    {
        public frmFileCreator()
        {
            InitializeComponent();

            CreateTooltips();       

            //try to set path to current user's desktop
            try
            {
                txtFilePath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }

            catch (Exception)
            {
                txtFilePath.Text = "C:/"; //seems like a reasonable default value
            }
        }

        #region DATA_MANIP
        private void MakeFiles(List<string> extensionList = null)
        {
            //function will run once per item in file group
            string extension = extensionList == null ? cboExtensions.Text.Trim() : extensionList[0];
            string filePath = txtFilePath.Text.Trim();
            string fileName = txtFileName.Text.Trim();

            try
            {
                //TODO check if file w/same name & extension already exists in directory, warn user



                //create file 
                string path = filePath + "/" + fileName + "." + extension;
                FileStream fs = File.Create(path);

                //if boilerplate is checked and valid, generate it and add to file
                if (chkBoilerplate.Checked && Boilerplate.HasBoilerplate(extension))
                {
                    string bp = Boilerplate.CreateBoilerplate(extension, fileName, chkFileGroup.Checked);
                    UTF8Encoding encoding = new UTF8Encoding();
                    fs.Write(encoding.GetBytes(bp), 0, encoding.GetByteCount(bp));
                }

                fs.Close();

                //attempt to open new file if needed
                if (chkOpenFiles.Checked)
                {
                    try
                    {
                        Process.Start(path);
                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Unable to open file. Check your selected directory to verify the file exists.", "Error");
                    }
                }

                MessageBox.Show(fileName + "." + extension + " created in " + filePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.None,
                    MessageBoxDefaultButton.Button1, (MessageBoxOptions)0x40000); //displays on top of other windows. helpful for when new files are opened 

                //if file group, repeat function for next file. stop the process if the list is empty
                if (extensionList != null && extensionList.Count() > 1)
                {
                    MakeFiles(extensionList.GetRange(1, extensionList.Count() - 1));
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Unable to create file. Verify file extension and path are valid.", "Error");
            }
        }

        private void CreateTooltips()
        {
            fileCreatorTooltips.SetToolTip(cboExtensions, "Select an option or type a custom extension");
            fileCreatorTooltips.SetToolTip(chkBoilerplate, "Adds some baseline code to the file to get you started.");
            fileCreatorTooltips.SetToolTip(chkFileGroup, "Creates a group of related files with the same name (i.e. HTML/JS/CSS)");
            fileCreatorTooltips.SetToolTip(chkOpenFiles, "Opens your new file(s) using your default application for each filetype");
            fileCreatorTooltips.SetToolTip(cboExtensions, "Select a supported extension or enter a custom one (at your own risk)");
        }

        //enables/disables boilerplate checkbox
        private void ToggleBoilerPlate(bool enable)
        {
            chkBoilerplate.Enabled = enable;
            if (enable == false) chkBoilerplate.Checked = false; //reset checked state
        }

        //enables/disables file group checkbox
        private void ToggleFileGroup(bool enable)
        {
            chkFileGroup.Enabled = enable;

            if (enable == false) chkFileGroup.Checked = false; //reset checked state
        }

        #endregion

        #region EVENT_HANDLERS

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //check if input fields are empty
            if (String.IsNullOrEmpty(txtFileName.Text.Trim()) || String.IsNullOrEmpty(txtFilePath.Text.Trim()) || String.IsNullOrEmpty(cboExtensions.Text.Trim()))
            {
                MessageBox.Show("All fields are required", "Error");
            }

            else if (chkFileGroup.Checked == true && FileGroup.HasFileGroup(cboExtensions.Text))
            {
                MakeFiles(FileGroup.GetGroup(cboExtensions.Text));
            }

            else
            {
                MakeFiles();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void cboExtensions_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboExtensions_TextUpdate(sender, e);
        }

        //checks user input; enables boilerplate checkbox where supported
        private void cboExtensions_TextUpdate(object sender, EventArgs e)
        {
            ToggleBoilerPlate(Boilerplate.HasBoilerplate(cboExtensions.Text));
            ToggleFileGroup(FileGroup.HasFileGroup(cboExtensions.Text));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFileName.Text = "";
            txtFilePath.Text = "";
            cboExtensions.Text = "";
            chkBoilerplate.Checked = chkBoilerplate.Enabled = false;
            chkFileGroup.Checked = chkFileGroup.Enabled = false;
        }

        private void chkFileGroup_CheckedChanged(object sender, EventArgs e)
        {
            //skip extension validation for boilerplate, in case the extension is something like CSS (which doesn't have bp, but HTML does)
            //this may need to be expanded on if groups are added that have no boilerplate for any extension 
            if (FileGroup.HasFileGroup(cboExtensions.Text) && chkFileGroup.Checked == true)
            {
                ToggleBoilerPlate(true); 
            }

            //else, re-validate extension
            else
            {
                ToggleBoilerPlate(Boilerplate.HasBoilerplate(cboExtensions.Text));
            }

            //change text for button + checkbox 
            btnGenerate.Text = chkFileGroup.Checked ? "&Create Files" : "&Create File";
            chkOpenFiles.Text = chkFileGroup.Checked ? "&Open Files When Complete" : "&Open File When Complete";
        }

        #endregion
    }
}