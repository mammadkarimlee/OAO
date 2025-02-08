namespace OAO
{
    partial class Form5
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
            button1 = new Button();
            button5 = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Showcard Gothic", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(252, 101);
            label1.Name = "label1";
            label1.Size = new Size(1546, 269);
            label1.TabIndex = 3;
            label1.Text = "Which planet in our solar system could technically float on water if there were a bathtub big enough?";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(0, 0, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Showcard Gothic", 16F);
            button1.Location = new Point(297, 599);
            button1.Name = "button1";
            button1.Size = new Size(242, 61);
            button1.TabIndex = 4;
            button1.Text = "Saturn 🌊\U0001fa90";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.BackColor = Color.FromArgb(0, 0, 192);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Showcard Gothic", 16F);
            button5.Location = new Point(698, 599);
            button5.Name = "button5";
            button5.Size = new Size(251, 61);
            button5.TabIndex = 8;
            button5.Text = "Jupiter ⚡🌀";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(0, 0, 192);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(1116, 599);
            button2.Name = "button2";
            button2.Size = new Size(225, 61);
            button2.TabIndex = 9;
            button2.Text = "Mars 🔴🚀";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.FromArgb(0, 0, 192);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(1484, 599);
            button3.Name = "button3";
            button3.Size = new Size(219, 61);
            button3.TabIndex = 10;
            button3.Text = "Venus  🌋🔥 ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(805, 370);
            label3.Name = "label3";
            label3.Size = new Size(418, 65);
            label3.TabIndex = 11;
            label3.Text = "🌞\U0001fa90🌍🌕✨🚀";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 192);
            ClientSize = new Size(1878, 998);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5";
            Text = "Form5";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private Button button5;
        private Button button2;
        private Button button3;
        private Label label3;
    }
}