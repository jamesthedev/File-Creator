using System;
using System.Windows.Forms;
using System.IO;

namespace File_Creator
{
    public partial class frmFileCreator : Form
    {
        public frmFileCreator()
        {
            InitializeComponent();
            extensionsTooltip.SetToolTip(cboExtensions, "Select an option or type a custom extension");

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

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //check if input fields are empty
            if (String.IsNullOrEmpty(txtFileName.Text.Trim()) || String.IsNullOrEmpty(txtFilePath.Text.Trim()) || String.IsNullOrEmpty(cboExtensions.Text.Trim()))
            {
                MessageBox.Show("All fields are required", "Error");
            }

            else
            {
                try
                {
                    //TODO check if file w/same name & extension already exists in directory, warn user

                    //create file 
                    String path = txtFilePath.Text.Trim() + "/" + txtFileName.Text.Trim() + "." + cboExtensions.Text.Trim();
                    FileStream fs = File.Create(path);
                    fs.Close();
                    
                    MessageBox.Show(txtFileName.Text.Trim() + "." + cboExtensions.Text.Trim() + " created in " + txtFilePath.Text.Trim(), "Success");
                }

                catch (Exception)
                {
                    MessageBox.Show("Unable to create file. Verify file extension and path are valid.", "Error");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFileName.Text = "";
            txtFilePath.Text = "";
            cboExtensions.Text = "";
        }
    }
}
