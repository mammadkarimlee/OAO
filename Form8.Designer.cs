namespace OAO
{
    partial class Form8
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
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 64);
            label1.Name = "label1";
            label1.Size = new Size(1466, 65);
            label1.TabIndex = 0;
            label1.Text = "indie rock artist that collabed with mitski 🎶✨🌙";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(196, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(1535, 836);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(709, 394);
            label2.Name = "label2";
            label2.Size = new Size(128, 40);
            label2.TabIndex = 3;
            label2.Text = "habibi";
            label2.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(1201, 603);
            button2.Name = "button2";
            button2.Size = new Size(168, 53);
            button2.TabIndex = 2;
            button2.Text = "hint 💡";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Showcard Gothic", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(642, 288);
            button1.Name = "button1";
            button1.Size = new Size(267, 72);
            button1.TabIndex = 2;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 128, 128);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(397, 175);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(742, 78);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(1915, 1010);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form8";
            Text = "Form8";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
    }
}