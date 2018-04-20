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
    public partial class ConsulterCr : Form
    {
        public string nom;
        public string prenom;
        public int cp;
        public int usercr;
        public string usertype;
        public static SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Cecile\Documents\ppe3\ppe3\pratic.mdf;Integrated Security=True");
        public List<int> ListId = new List<int>();
        public ConsulterCr()
        {
            InitializeComponent();
        }

        private void ConsulterCr_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'praticDataSet.CompteRendu'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.compteRenduTableAdapter.Fill(this.praticDataSet.CompteRendu);
            GetRegion();
            comboBox1visiteurs.Hide();
            label2.Hide();
            comboboxcr.Hide();
            label1.Hide();
        }

        private void GetRegion()
        {
            comboBoxregion.Items.Clear();
            connect.Open();
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select DISTINCT cp From Visiteur";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBoxregion.Items.Add(dr["cp"].ToString());
            }
            connect.Close();
        }

        private void GetVisiteurs()
        {
            comboBox1visiteurs.Items.Clear();
            connect.Open();
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select nom, prenom From Visiteur WHERE cp = '" + comboBoxregion.Text.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1visiteurs.Items.Add(dr["nom"].ToString() + ' ' + dr["prenom"].ToString());
            }
            connect.Close();
        }

        private void GetCr()
        {
            string[] tab =  Test(comboBox1visiteurs.Text); 
            comboboxcr.Items.Clear();
            connect.Open();
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From CompteRendu INNER JOIN Visiteur ON CompteRendu.Id_visiteur = Visiteur.Id_visiteur WHERE nom = '" + tab[0] + "' AND prenom = '" + tab[1] + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboboxcr.Items.Add(dr["date"]);
                ListId.Add(Convert.ToInt16(dr["id"]));

            }
            connect.Close();
        }

        private void comboBoxregion_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetVisiteurs();
            comboBox1visiteurs.Text = "";
            comboBox1visiteurs.Show();
            label1.Show();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            richTextBox1.Clear();
            comboboxcr.Hide();
            label2.Hide();
        }

        private void comboBox1visiteurs_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            GetCr();
            comboboxcr.Text = "";
            comboboxcr.Show();
            label2.Show();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            richTextBox1.Clear();
        }

        private void comboboxcr_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currentcomboBoxcrIndex = comboboxcr.SelectedIndex;
            Fillcr(currentcomboBoxcrIndex);
        }

        private void buttonretour_Click(object sender, EventArgs e)
        {
            this.Hide();
            accueil_delegue openform = new accueil_delegue();
            openform.Show();
        }

        private void Fillcr(int index)
        {
            connect.Open();
            string sql = "select * from CompteRendu where id = '" + ListId[index] + "'";
            SqlCommand cmd = new SqlCommand(sql, connect);
            SqlDataReader dr;

            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string date = dr.GetDateTime(1).ToString("yyyy-MM-dd");
                    string motif = dr.GetString(2);
                    string docteur = dr.GetString(3);
                    string echantillon = dr.GetString(4);
                    string quantite = dr.GetInt32(5).ToString();
                    string bilan = dr.GetString(7);

                    textBox2.Text = quantite;
                    textBox3.Text = date;
                    textBox1.Text = motif;
                    textBox4.Text = docteur;
                    textBox5.Text = echantillon;
                    richTextBox1.Text = bilan;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connect.Close();
            connect.Open();
            string sql2 = "select specialisation from Praticien where nom = '" + textBox4.Text + "'";
            SqlCommand cmd2 = new SqlCommand(sql2, connect);
            SqlDataReader dr2;

            try
            {
                dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    string spécilisation = dr2.GetString(0);
                    textBox6.Text = spécilisation;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.Close();
        }

        private string[] Test(string param)
        {
            string prenom = "";
            string nom = "";
            string[] tableau1 = new string[2]; 
            char[] tab = new char[60];
            tab = param.ToArray();
            for (int i = 0; i < tab.Count(); i++)
            {
                if (tab[i] != ' ')
                {
                    prenom += tab[i];
                }
                else
                {
                    i++;
                    nom = param.Substring(i);
                    tableau1[0] = prenom;
                    tableau1[1] = nom; 
                    return tableau1;
                }
            }
            return tableau1; 

        }

    

    }
}
