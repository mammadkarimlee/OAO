namespace OAO
{
    partial class Form3
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(151, 151);
            label1.Name = "label1";
            label1.Size = new Size(1492, 60);
            label1.TabIndex = 0;
            label1.Text = "What was the first message ever sent over the internet?";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(1851, 943);
            panel1.TabIndex = 1;
            // 
            // button4
            // 
            button4.BackColor = Color.Blue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(691, 742);
            button4.Name = "button4";
            button4.Size = new Size(559, 64);
            button4.TabIndex = 4;
            button4.Text = "\"Welcome to the Future\" 🤖🚀✨\n";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Blue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Showcard Gothic", 14F);
            button3.Location = new Point(813, 504);
            button3.Name = "button3";
            button3.Size = new Size(292, 62);
            button3.TabIndex = 3;
            button3.Text = "\"Lo\" 👋😎";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Showcard Gothic", 14F);
            button2.Location = new Point(727, 663);
            button2.Name = "button2";
            button2.Size = new Size(482, 64);
            button2.TabIndex = 2;
            button2.Text = "\"Login Successful\" 🔑✅🎉";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Showcard Gothic", 14F);
            button1.Location = new Point(765, 586);
            button1.Name = "button1";
            button1.Size = new Size(397, 61);
            button1.TabIndex = 1;
            button1.Text = "\"Hello, World!\" 👋🌍✨";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(1875, 1006);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form3";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button3;
    }
}