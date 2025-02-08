using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OAO;

public partial class Form2 : Form
{
    public Form2()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string correctAnswer = "green";
        string lowercorrectAnswer = correctAnswer.ToLower();
        if (textBox1.Text == correctAnswer)
        {
            this.Close();
            Form3 form3 = new Form3();
            form3.Show();



        }
        else
        {

            this.Close();
            Form4 form4 = new Form4();
            form4.Show();




        }


    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        textBox1.CharacterCasing = CharacterCasing.Lower;
    }
}
