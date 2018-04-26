using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.NetworkFlow
{
    public partial class UserInterface : Form
    {

        FlowNetwork _maxFlowNet;
        int _maxFlowValue;
        public UserInterface()
        {
            InitializeComponent();
        }

        private void uxOpenFile_Click(object sender, EventArgs e)
        {
            if (uxOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // call methods
                    uxTextBox.Text = "*insert text here*";
                    MessageBox.Show("File read");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void uxSaveFile_Click(object sender, EventArgs e)
        {
            if (uxSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // call all of the code first
                    uxTextBox.Text = "# saved #";   
                    MessageBox.Show("File written.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
