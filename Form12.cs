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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string correct11 = "hadaf lyceum";
            if (textBox1.Text == correct11)

            {
                this.Close();
                Form13 form13 = new Form13();
                form13.Show();

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
