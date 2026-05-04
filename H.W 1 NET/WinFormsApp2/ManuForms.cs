using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class ManuForms : Form
    {
        public ManuForms()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about =new AboutForm();
            about.MdiParent = this;
            about.Show();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void singInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SingInForm singIn = new SingInForm();
            singIn.MdiParent = this;
            singIn.Show();
        }

        private void ManuForms_Load(object sender, EventArgs e)
        {

        }
    }
}
