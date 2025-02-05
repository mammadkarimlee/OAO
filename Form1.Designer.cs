namespace OAO
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
            label1 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MingLiU_MSCS-ExtB", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 32);
            label1.Name = "label1";
            label1.Size = new Size(279, 144);
            label1.TabIndex = 0;
            label1.Text = "OAO";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Font = new Font("Yu Gothic UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(143, 271);
            button1.Name = "button1";
            button1.Size = new Size(171, 62);
            button1.TabIndex = 1;
            button1.Text = "New Game";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(684, 130);
            panel1.Name = "panel1";
            panel1.Size = new Size(479, 585);
            panel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.Font = new Font("Yu Gothic UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(143, 385);
            button2.Name = "button2";
            button2.Size = new Size(171, 62);
            button2.TabIndex = 2;
            button2.Text = "Quit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1921, 962);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Panel panel1;
        private Button button2;
    }
}
