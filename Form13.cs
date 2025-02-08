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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private async void label1_Click(object sender, EventArgs e)
        {

        }

        private async void Form13_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

            label1.Visible = true;
            await Task.Delay(2000);
            label2.Visible = true;
            await Task.Delay(2000);
            label3.Visible = true;
            await Task.Delay(2000);
            label4.Visible = true;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
