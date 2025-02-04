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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string correct12 = "0591";
            if (textBox1.Text == correct12)
            {
                this.Close();
                Form12 form12 = new Form12();
                form12.Show();

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
