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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string correct11 = "5800";
            if (textBox1.Text == correct11)
            {
                this.Close();
                Form11 form11 = new Form11();
                form11.Show();


            }
            else
            {
                this.Close();
                Form4 form4 = new Form4();
                form4.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
        }
    }
}
