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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form7 form7 = new Form7();
            form7.Show();

        }
    }
}
