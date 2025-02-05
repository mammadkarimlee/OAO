namespace OAO
{
    partial class Form13
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
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(1847, 956);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(192, 192, 255);
            label4.Location = new Point(671, 645);
            label4.Name = "label4";
            label4.Size = new Size(486, 282);
            label4.TabIndex = 3;
            label4.Text = "Creators: Nurlan Huseynli\r\n               Orkhan Haciyev\r\n               Aykhan Alizade\r\n               Oghuz Mamiyev";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(192, 192, 255);
            label3.Location = new Point(651, 421);
            label3.Name = "label3";
            label3.Size = new Size(506, 59);
            label3.TabIndex = 2;
            label3.Text = "Instructor: Mammad Karimli";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 192, 255);
            label2.Location = new Point(13, 193);
            label2.Name = "label2";
            label2.Size = new Size(1834, 96);
            label2.TabIndex = 1;
            label2.Text = "Congratulations! You successfully passed the quiz/game.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 192, 255);
            label1.Location = new Point(438, 12);
            label1.Name = "label1";
            label1.Size = new Size(894, 191);
            label1.TabIndex = 0;
            label1.Text = "OAO GAMES";
            label1.Click += label1_Click;
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1871, 1003);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form13";
            Text = "Form13";
            WindowState = FormWindowState.Maximized;
            Load += Form13_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}