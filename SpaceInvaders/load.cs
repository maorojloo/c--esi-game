using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public partial class load : Form
    {
        public load()
        {
            InitializeComponent();
        }

        private void load_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        int t=0;
        private void timer1_Tick(object sender, EventArgs e)
        { 
            t++;
           // label1.Text = t.ToString();
           
            if(t==7)
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();


            }

        }
    }
}
