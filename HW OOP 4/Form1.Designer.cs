namespace HW_OOP_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MS_AddAnimal = new ToolStripMenuItem();
            MS_ViewSys = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // MS_AddAnimal
            // 
            MS_AddAnimal.Name = "MS_AddAnimal";
            MS_AddAnimal.Size = new Size(80, 20);
            MS_AddAnimal.Text = "Add animal";
            MS_AddAnimal.Click += MS_AddAnimal_Click;
            // 
            // MS_ViewSys
            // 
            MS_ViewSys.Name = "MS_ViewSys";
            MS_ViewSys.Size = new Size(85, 20);
            MS_ViewSys.Text = "View System";
            MS_ViewSys.Click += MS_ViewSys_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { MS_AddAnimal, MS_ViewSys });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem MS_AddAnimal;
        private ToolStripMenuItem MS_ViewSys;
        private MenuStrip menuStrip1;
    }
}
