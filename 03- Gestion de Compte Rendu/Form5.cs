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
    public partial class Form5 : Form
    {

        public static SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CECILE\Documents\ppe3\ppe3\pratic.mdf;Integrated Security=True");
        public Form5()
        {
            InitializeComponent();
        }

        private void button1retour_Click(object sender, EventArgs e)
        {
            Form2 openForm = new Form2();
            openForm.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            comboBoxproduits.Items.Clear();
            connect.Open();
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select nom From Medicaments";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBoxproduits.Items.Add(dr["nom"].ToString());
            }



            connect.Close();
        }

        private void comboBoxproduits_SelectedIndexChanged(object sender, EventArgs e)
        {
            connect.Open();
            string sql = "select * from Medicaments where nom = '" + comboBoxproduits.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, connect);
            SqlDataReader dr;

            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    string nom = dr.GetString(1);
                    string but = dr.GetString(2);
                    string effets_secondaires = dr.GetString(3);
                    string composants = dr.GetString(4);
                    string prix_echant = dr.GetInt32(5).ToString();
                    

                    textBox1.Text = nom;
                    textBox2.Text = but;
                    textBox3.Text = effets_secondaires;
                    textBox4.Text = composants;
                    textBox5.Text = prix_echant;
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connect.Close();
        }
    }
}
