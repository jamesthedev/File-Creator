using System;
using System.Windows.Forms;
using System.IO;
using File_Creator.boilerplate;
using System.Text;

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

                    //if boilerplate is checked and valid, generate it
                    if (chkBoilerplate.Checked && Boilerplate.HasBoilerplate(cboExtensions.Text.Trim()))
                    {
                        string bp = Boilerplate.CreateBoilerplate(cboExtensions.Text.Trim(), txtFileName.Text.Trim());
                        UTF8Encoding encoding = new UTF8Encoding();
                        fs.Write(encoding.GetBytes(bp), 0, encoding.GetByteCount(bp));
                    }
                    fs.Close();

                    MessageBox.Show(txtFileName.Text.Trim() + "." + cboExtensions.Text.Trim() + " created in " + txtFilePath.Text.Trim(), "Success");
                }

                catch (Exception ex)
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

        private void cboExtensions_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboExtensions_TextUpdate(sender, e);
        }

        //checks user input; enables boilerplate checkbox where supported
        private void cboExtensions_TextUpdate(object sender, EventArgs e)
        {
            if (Boilerplate.HasBoilerplate(cboExtensions.Text))
            {
                ToggleBoilerplate(true);
            }

            else
            {
                ToggleBoilerplate(false);
            }
        }

        private void ToggleBoilerplate(bool enable)
        {
            chkBoilerplate.Enabled = enable;
            chkBoilerplate.Visible = enable;
        }
    }
}