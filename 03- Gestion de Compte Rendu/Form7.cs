using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppe3
{
    public partial class accueil_delegue : Form
    {
        public accueil_delegue()
        {
            InitializeComponent();
        }

        private void buttonretour_Click(object sender, EventArgs e)
        {
            Form1 openForm = new Form1();
            openForm.Show();
            this.Hide();
        }

        private void linkLabelconsultevisite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form8 openForm = new Form8();
            openForm.Show();
            this.Hide();
        }

        private void linkLabelconsultecr_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConsulterCr openForm = new ConsulterCr();
            openForm.Show();
            this.Hide();
        }

        private void accueil_delegue_Load(object sender, EventArgs e)
        {
            this.user.Text = Form1.username;
        }
    }
}
