﻿namespace OAO
{
    partial class Form10
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
            label1.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(164, 52);
            label1.Name = "label1";
            label1.Size = new Size(536, 89);
            label1.TabIndex = 0;
            label1.Text = "Azersun 🌞\U0001f96b";
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
            panel1.Location = new Point(510, 133);
            panel1.Name = "panel1";
            panel1.Size = new Size(832, 652);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Showcard Gothic", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(286, 330);
            label2.Name = "label2";
            label2.Size = new Size(284, 64);
            label2.TabIndex = 4;
            label2.Text = "stadium 🏟️ ";
            label2.Visible = false;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Showcard Gothic", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(588, 473);
            button2.Name = "button2";
            button2.Size = new Size(211, 76);
            button2.TabIndex = 3;
            button2.Text = "Hint 💡";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(320, 251);
            button1.Name = "button1";
            button1.Size = new Size(184, 58);
            button1.TabIndex = 2;
            button1.Text = "Submit\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(192, 0, 0);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(246, 161);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(324, 54);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(1876, 1009);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form10";
            Text = "Form10";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Label label2;
    }
}