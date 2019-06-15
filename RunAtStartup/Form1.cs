using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace RunAtStartup
{
    public partial class frmStartup : Form
    {
        // The path to the key where Windows looks for startup applications
        RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        int rc = 0;

        public frmStartup()
        {
            InitializeComponent();
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (textBoxRegistryKey.Text.Length < 3)
            {
                MessageBox.Show("Enter at least 3 characters in Text Box","Enter text", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (radioButtonAdd.Checked)
                {
                    // Add the value in the registry so that the application runs at startup
                    //rc = 
                    if (textBoxAppPath.Text.Length > 10)
                    {
                        rkApp.SetValue(textBoxRegistryKey.Text, textBoxAppPath.Text);
                    }
                    else
                    {
                        MessageBox.Show("Enter at least 10 character path", "Enter at path",  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (radioButtonDelete.Checked)
                {
                    // Remove the value from the registry so that the application doesn't start
                    //rc = 
                    rkApp.DeleteValue(textBoxRegistryKey.Text, false);
                    
                }
                else MessageBox.Show("No Button Selected");
                
                MessageBox.Show("OK","OK",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chkRun_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmStartup_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxRegistryKey_TextChanged(object sender, EventArgs e)
        {

        }
    }
}