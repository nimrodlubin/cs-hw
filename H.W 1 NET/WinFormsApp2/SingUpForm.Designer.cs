namespace WinFormsApp2
{
    partial class SingUpForm
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
            TB_NewN = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TB_NewID = new TextBox();
            label3 = new Label();
            BTN_save = new Button();
            SuspendLayout();
            // 
            // TB_NewN
            // 
            TB_NewN.Location = new Point(15, 141);
            TB_NewN.Name = "TB_NewN";
            TB_NewN.Size = new Size(196, 27);
            TB_NewN.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(236, 141);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 1;
            label1.Text = "שם מלא";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 181);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 2;
            label2.Text = "תעודת זהות";
            // 
            // TB_NewID
            // 
            TB_NewID.Location = new Point(15, 178);
            TB_NewID.Name = "TB_NewID";
            TB_NewID.Size = new Size(196, 27);
            TB_NewID.TabIndex = 3;
            TB_NewID.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Info;
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(52, 96);
            label3.Name = "label3";
            label3.Size = new Size(198, 20);
            label3.TabIndex = 4;
            label3.Text = "אנא מלאו את הפרטים הבאים";
            // 
            // BTN_save
            // 
            BTN_save.Location = new Point(76, 251);
            BTN_save.Name = "BTN_save";
            BTN_save.Size = new Size(135, 67);
            BTN_save.TabIndex = 5;
            BTN_save.Text = "שמור והמשך";
            BTN_save.UseVisualStyleBackColor = true;
            BTN_save.Click += BTN_save_Click;
            // 
            // SingUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BTN_save);
            Controls.Add(label3);
            Controls.Add(TB_NewID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TB_NewN);
            Name = "SingUpForm";
            Size = new Size(329, 422);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_NewN;
        private Label label1;
        private Label label2;
        private TextBox TB_NewID;
        private Label label3;
        private Button BTN_save;
    }
}
