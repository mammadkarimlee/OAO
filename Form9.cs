using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OAO
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string correct10 = "queue";
            if (textBox1.Text == correct10)
            {
                this.Close();
                Form8 form8 = new Form8();
                form8.Show();


            }
            else
            {
                this.Close();
                Form4 form4 = new Form4();
                form4.Show();
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
