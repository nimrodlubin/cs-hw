using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class SingUpForm : Form
    {
        public SingUpForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTN_save_Click(object sender, EventArgs e)
        {
            if (TB_NewID.Text == "" || TB_NewN.Text == "") 
            {
                MessageBox.Show("נא למלא את כל הפרטים", "שגיאה");
                return;
            }
            int oldSize = Program.users.GetLength(0);
            string[,] AddUsers = new string[oldSize + 1,2];

            for (int i = 0; i < oldSize; i++)
            {
                AddUsers [i,0] = Program.users[i,0];
                AddUsers [i,1] = Program.users[i,1];
            }
            AddUsers [oldSize,0] = TB_NewID.Text;
			AddUsers[oldSize, 1] = TB_NewN.Text;

			Program.users= AddUsers;

			MessageBox.Show("נרשמת בהצלחה!", "SingUp");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
