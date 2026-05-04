using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class SingInForm : Form
    {
        public SingInForm()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void BTN_login_Click(object sender, EventArgs e)
        {
            String inputID = TB_id.Text;
            string inputN = "";
            bool exesit = false;

            for (int i = 0; i < Program.users.Length; i++)
            {
                if (Program.users[i,0] == inputID)
                {
                    exesit = true;
                    break;
                }
            }

            if (exesit)
            {
                MessageBox.Show("נכנסת בהצלחה", "כניסה", MessageBoxButtons.OK);
                PlayForm play = new PlayForm(inputN);
                play.MdiParent = this.MdiParent;
                play.Show();
                this.Close();
                return;
            }
            else
            {
				MessageBox.Show("תעודת זהות לא קיימת", "EROR", MessageBoxButtons.CancelTryContinue,MessageBoxIcon.Error);
			}
			this.Close();
        }

        private void BTN_SignUp_Click(object sender, EventArgs e)
        {
            SingUpForm singUp = new SingUpForm();
            singUp.MdiParent = this.MdiParent;
            singUp.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
