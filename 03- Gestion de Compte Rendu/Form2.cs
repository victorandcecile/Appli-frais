using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ppe3;

namespace ppe3
{
   
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static object Control { get; internal set; }

        private void retourconnexion_Click(object sender, EventArgs e)
        {
            Form1 openForm = new Form1();
            openForm.Show();
            this.Hide();
        }

        private void linklabelcompterendu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 openForm = new Form3();
            openForm.Show();
            this.Hide();
        }

        private void linklabelpraticiens_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 openForm = new Form4();
            openForm.Show();
            this.Hide();
        }

        private void linklabelmedicaments_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 openForm = new Form5();
            openForm.Show();
            this.Hide();
        }

        private void consultecr_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form6 openForm = new Form6();
            openForm.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.user.Text = Form1.username;
        }
    }
}
