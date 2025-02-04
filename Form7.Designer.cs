namespace OAO;

partial class Form7
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
        textBox1 = new TextBox();
        panel1 = new Panel();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(190, 31);
        label1.Name = "label1";
        label1.Size = new Size(679, 74);
        label1.TabIndex = 0;
        label1.Text = "Doha pz aol dhytlza jvsvy?";
        // 
        // button1
        // 
        button1.BackColor = Color.FromArgb(192, 192, 255);
        button1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button1.Location = new Point(426, 241);
        button1.Name = "button1";
        button1.Size = new Size(143, 56);
        button1.TabIndex = 1;
        button1.Text = "submit";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // textBox1
        // 
        textBox1.BackColor = Color.FromArgb(192, 192, 255);
        textBox1.Location = new Point(261, 148);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(495, 61);
        textBox1.TabIndex = 2;
        textBox1.TextChanged += textBox1_TextChanged;
        // 
        // panel1
        // 
        panel1.Anchor = AnchorStyles.None;
        panel1.Controls.Add(label1);
        panel1.Controls.Add(button1);
        panel1.Controls.Add(textBox1);
        panel1.Location = new Point(394, 142);
        panel1.Name = "panel1";
        panel1.Size = new Size(1042, 501);
        panel1.TabIndex = 3;
        // 
        // Form7
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(192, 192, 255);
        ClientSize = new Size(1900, 1009);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "Form7";
        Text = "Form7";
        WindowState = FormWindowState.Maximized;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Label label1;
    private Button button1;
    private TextBox textBox1;
    private Panel panel1;
}