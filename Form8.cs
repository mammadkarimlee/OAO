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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string correct11 = "tamino";
            if (textBox1.Text == correct11)
            {
                this.Close();
                Form10 form10 = new Form10();
                form10.Show();

                    
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
