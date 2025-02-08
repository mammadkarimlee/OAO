namespace OAO
{
    partial class Form6
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
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(473, 47);
            label1.Name = "label1";
            label1.Size = new Size(312, 65);
            label1.TabIndex = 0;
            label1.Text = "CONGRATS!";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(323, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(1239, 503);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(522, 253);
            button1.Name = "button1";
            button1.Size = new Size(182, 69);
            button1.TabIndex = 2;
            button1.Text = "Next Stage";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 137);
            label2.Name = "label2";
            label2.Size = new Size(1107, 65);
            label2.TabIndex = 1;
            label2.Text = "YOU SUCCESFULLY PASSED THE FIRST STAGE";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(1876, 1005);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form6";
            Text = "Form6";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Button button1;
    }
}