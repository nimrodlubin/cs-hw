namespace WinFormsApp2
{
    partial class SingInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            TB_id = new TextBox();
            BTN_login = new Button();
            BTN_SignUp = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(49, 70);
            label1.Name = "label1";
            label1.Size = new Size(196, 32);
            label1.TabIndex = 0;
            label1.Text = "הכנס תעודת זהות";
            // 
            // TB_id
            // 
            TB_id.Location = new Point(17, 116);
            TB_id.Name = "TB_id";
            TB_id.Size = new Size(275, 27);
            TB_id.TabIndex = 1;
            TB_id.TextChanged += textBox1_TextChanged_1;
            // 
            // BTN_login
            // 
            BTN_login.Font = new Font("Segoe UI", 14F);
            BTN_login.Location = new Point(86, 166);
            BTN_login.Name = "BTN_login";
            BTN_login.Size = new Size(114, 39);
            BTN_login.TabIndex = 2;
            BTN_login.Text = "התחבר";
            BTN_login.UseVisualStyleBackColor = true;
            BTN_login.Click += BTN_login_Click;
            // 
            // BTN_SignUp
            // 
            BTN_SignUp.Font = new Font("Segoe UI", 14F);
            BTN_SignUp.Location = new Point(86, 276);
            BTN_SignUp.Name = "BTN_SignUp";
            BTN_SignUp.Size = new Size(114, 39);
            BTN_SignUp.TabIndex = 3;
            BTN_SignUp.Text = "להירשם";
            BTN_SignUp.UseVisualStyleBackColor = true;
            BTN_SignUp.Click += BTN_SignUp_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(122, 221);
            label2.Name = "label2";
            label2.Size = new Size(35, 32);
            label2.TabIndex = 4;
            label2.Text = "או";
            label2.Click += label2_Click;
            // 
            // SingInForm
            // 
            ClientSize = new Size(322, 453);
            Controls.Add(label2);
            Controls.Add(BTN_SignUp);
            Controls.Add(BTN_login);
            Controls.Add(TB_id);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlDark;
            Name = "SingInForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TB_id;
        private Button BTN_login;
        private Button BTN_SignUp;
        private Label label2;
    }
}
