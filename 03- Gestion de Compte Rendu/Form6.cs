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
    public partial class Form6 : Form
    {
        public static SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CECILE\Documents\ppe3\ppe3\pratic.mdf;Integrated Security=True");
        public List<int> ListId = new List<int>();
        public Form6()
        {
            InitializeComponent();
        }

        private void button1retour_Click(object sender, EventArgs e)
        {
            Form2 openForm = new Form2();
            openForm.Show();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            user.Hide();
            user.Text = Form1.username;
            comboBoxcr.Items.Clear();
            connect.Open();
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From CompteRendu INNER JOIN Visiteur ON CompteRendu.Id_visiteur = Visiteur.Id_visiteur WHERE prenom = '" + user.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBoxcr.Items.Add(dr["date"]);
                ListId.Add(Convert.ToInt16(dr["id"]));
            }



            connect.Close();
        }

        private void comboBoxcr_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currentcomboBoxcrIndex = comboBoxcr.SelectedIndex;
            connect.Open();
            string sql = " Select * From CompteRendu INNER JOIN Visiteur ON CompteRendu.Id_visiteur = Visiteur.Id_visiteur WHERE id = '"+ ListId[currentcomboBoxcrIndex] +"'";
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
            SqlCommand cmd2= new SqlCommand(sql2, connect);
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

        private void button1actualiser_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
            else
            {
                connect.Open();
                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE CompteRendu set docteur = '" + textBox4.Text + "', echantillon = '" + textBox5.Text + "', motif = '" + textBox1.Text + "', quantité = '" + textBox2.Text + "', bilan = '" + richTextBox1.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                connect.Close();
            }
        }
    }
}
