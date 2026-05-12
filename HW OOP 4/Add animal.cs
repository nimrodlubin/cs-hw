using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HW_OOP_4
{
    public partial class Add_animal : Form
    {
        public Add_animal()
        {
            InitializeComponent();

        }

        private void Add_animal_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            string name = TB_Name.Text;
            int age = int.Parse(TB_Age.Text);

            if (CB_Dog.Checked)
            {
                Program.animals[Program.count]= new Dog(name,age);
            }
            else
            {
                Program.animals[Program.count] = new Cat (name,age);
            }
            Program.count++;

            MessageBox.Show("Animal added");
            this.Close();
        }
    }
}
