using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OAO
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string correctAnswer = "Green";
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
    }
}
