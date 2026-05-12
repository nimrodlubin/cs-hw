namespace HW_OOP_4
{
    partial class Add_animal
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            L_name = new Label();
            L_age = new Label();
            TB_Name = new TextBox();
            TB_Age = new TextBox();
            label3 = new Label();
            BTN_Add = new Button();
            CB_Cat = new CheckBox();
            CB_Dog = new CheckBox();
            SuspendLayout();
            // 
            // L_name
            // 
            L_name.AutoSize = true;
            L_name.Location = new Point(161, 113);
            L_name.Name = "L_name";
            L_name.Size = new Size(54, 15);
            L_name.TabIndex = 0;
            L_name.Text = "שם החיה";
            // 
            // L_age
            // 
            L_age.AutoSize = true;
            L_age.Location = new Point(161, 154);
            L_age.Name = "L_age";
            L_age.Size = new Size(52, 15);
            L_age.TabIndex = 1;
            L_age.Text = "גיל החיה";
            // 
            // TB_Name
            // 
            TB_Name.Location = new Point(41, 105);
            TB_Name.Name = "TB_Name";
            TB_Name.Size = new Size(100, 23);
            TB_Name.TabIndex = 2;
            // 
            // TB_Age
            // 
            TB_Age.Location = new Point(41, 146);
            TB_Age.Name = "TB_Age";
            TB_Age.Size = new Size(100, 23);
            TB_Age.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(68, 59);
            label3.Name = "label3";
            label3.Size = new Size(115, 28);
            label3.TabIndex = 4;
            label3.Text = "הוספת חיה";
            label3.Click += label3_Click;
            // 
            // BTN_Add
            // 
            BTN_Add.Location = new Point(66, 218);
            BTN_Add.Name = "BTN_Add";
            BTN_Add.Size = new Size(75, 23);
            BTN_Add.TabIndex = 5;
            BTN_Add.Text = "הוספה";
            BTN_Add.UseVisualStyleBackColor = true;
            BTN_Add.Click += BTN_Add_Click;
            // 
            // CB_Cat
            // 
            CB_Cat.AutoSize = true;
            CB_Cat.Location = new Point(41, 193);
            CB_Cat.Name = "CB_Cat";
            CB_Cat.Size = new Size(53, 19);
            CB_Cat.TabIndex = 6;
            CB_Cat.Text = "חתול";
            CB_Cat.UseVisualStyleBackColor = true;
            // 
            // CB_Dog
            // 
            CB_Dog.AutoSize = true;
            CB_Dog.Location = new Point(94, 193);
            CB_Dog.Name = "CB_Dog";
            CB_Dog.Size = new Size(47, 19);
            CB_Dog.TabIndex = 7;
            CB_Dog.Text = "כלב";
            CB_Dog.UseVisualStyleBackColor = true;
            // 
            // Add_animal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 450);
            Controls.Add(CB_Dog);
            Controls.Add(CB_Cat);
            Controls.Add(BTN_Add);
            Controls.Add(label3);
            Controls.Add(TB_Age);
            Controls.Add(TB_Name);
            Controls.Add(L_age);
            Controls.Add(L_name);
            Name = "Add_animal";
            Text = "Add_animal";
            Load += Add_animal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label L_name;
        private Label L_age;
        private TextBox TB_Name;
        private TextBox TB_Age;
        private Label label3;
        private Button BTN_Add;
        private CheckBox CB_Cat;
        private CheckBox CB_Dog;
    }
}