﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OAO
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.CharacterCasing = CharacterCasing.Lower;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string correct8 = "red";
            if (textBox1.Text == correct8)
            {

                this.Close();
                Form9 form9 = new Form9();
                form9.Show();

            }
            else
            {

                Form4 form4 = new Form4();  
                form4.Show();

            }
        }
    }
}
