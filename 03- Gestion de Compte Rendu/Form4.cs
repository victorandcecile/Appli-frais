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
using System.Data.SqlServerCe;

namespace ppe3
{
    public partial class Form4 : Form
    {
      
        public static SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CECILE\Documents\ppe3\ppe3\pratic.mdf;Integrated Security=True");
        public Form4()
        {
            InitializeComponent();
        }

        private void button1retour_Click(object sender, EventArgs e)
        {
            Form2 openForm = new Form2();
            openForm.Show();
            this.Hide();
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            comboBoxmedecin.Items.Clear();
            connect.Open();
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select nom From Praticien";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBoxmedecin.Items.Add(dr["nom"].ToString());
            }
            connect.Close();
        }

        private void comboBoxmedecin_SelectedIndexChanged(object sender, EventArgs e)
        {
            Moyenne();
            connect.Open();
            string sql = "select * from Praticien where nom = '" + comboBoxmedecin.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, connect);
            SqlDataReader dr;

            try
            {
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {                  
                    string nom = dr.GetString(1);
                    string prenom = dr.GetString(2);
                    string specialisation = dr.GetString(3);
                    string rue = dr.GetString(4);
                    string numrue = dr.GetInt32(5).ToString();
                    string cp = dr.GetInt32(6).ToString();

                    textBox1.Text = nom;
                    textBox2.Text = prenom;
                    textBox3.Text = specialisation;
                    textBox4.Text = rue;
                    textBox5.Text = numrue;
                    textBox6.Text = cp;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connect.Close();
        }

        private void Moyenne()
        {
            connect.Open();
            string sql = "SELECT AVG(note) FROM CompteRendu where docteur = '"+ comboBoxmedecin.Text+ "'";
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string note = dr.GetValue(0).ToString();
                    moyenne.Text = note;
                }
            connect.Close();
        }
    }
}
