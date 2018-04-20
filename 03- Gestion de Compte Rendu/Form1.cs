using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ppe3

{

    public partial class Form1 : Form
    {
        public static string iduser;
        public static string username;
        public static string username2;
        public string usertype;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            passwordbox.UseSystemPasswordChar = true;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Veuillez vous connecter";
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection connexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CECILE\Documents\ppe3\ppe3\pratic.mdf;Integrated Security=True");
            string query = "Select * From Visiteur Where username = '" + usernamebox.Text.Trim() + "'and motdepasse = '" + passwordbox.Text.Trim() + "'"; 
            SqlDataAdapter sda = new SqlDataAdapter(query, connexion);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                usertype = dtbl.Rows[0][7].ToString();
                if (usertype == "visiteur")
                {
                    iduser = dtbl.Rows[0][0].ToString();
                    username2 = dtbl.Rows[0][1].ToString();
                    username = dtbl.Rows[0][9].ToString();
                    Form2 openform = new Form2();
                    this.Hide();
                    openform.Show();
                    
                }

                else if (usertype == "delegue")
                {
                    iduser = dtbl.Rows[0][0].ToString();
                    username2 = dtbl.Rows[0][1].ToString();
                    username = dtbl.Rows[0][9].ToString();
                    accueil_delegue openform = new accueil_delegue();
                    this.Hide();
                    openform.Show();
                }

                else if (usertype == "resp")
                {
                    username = dtbl.Rows[0][9].ToString();
                    accueil_responsable openform = new accueil_responsable();
                    this.Hide();
                    openform.Show();
                }

                else
                {

                    MessageBox.Show("Mauvais identifiants, veuillez réessayer.");
                }
                 
            }
        }
    }
}

    