namespace HW_OOP_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MS_AddAnimal_Click(object sender, EventArgs e)
        {
            Add_animal frmAdd = new Add_animal();
            frmAdd.ShowDialog();
        }

        private void MS_ViewSys_Click(object sender, EventArgs e)
        {
            View_System frmView = new View_System();
            frmView.MdiParent = this;
            frmView.Show();
        }
    }
}
