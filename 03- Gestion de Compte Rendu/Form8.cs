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
    public partial class Form8 : Form
    {

        public static SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CECILE\Documents\ppe3\ppe3\pratic.mdf;Integrated Security=True");
        public Form8()
        {
            InitializeComponent();
        }

        private void retourcr_Click(object sender, EventArgs e)
        {
            accueil_delegue openForm = new accueil_delegue();
            openForm.Show();
            this.Hide();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            Moyenne();
            Medecin();
            Medicaments();
            this.user.Hide();
            this.user.Text = Form1.username2;
            this.id.Text = Form1.iduser;
            
        }

        public void Medecin()
        {
            comboBox1med.Items.Clear();
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
                comboBox1med.Items.Add(dr["nom"].ToString());
            }



            connect.Close();
        }

        public void Medicaments()
        {
            comboBox2ech.Items.Clear();
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
                comboBox2ech.Items.Add(dr["nom"].ToString());
            }



            connect.Close();
        }

        private void ajoutercr_Click(object sender, EventArgs e)
        {
            if (textBox1mot.Text == "" || textBox2quant.Text == "" || richTextBox1bil.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
            connect.Open();
                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into CompteRendu(date, docteur, motif, bilan, echantillon, quantité, Id_visiteur, note) values ('"
                 + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + comboBox1med.Text + "','" + textBox1mot.Text + "','"
                 + richTextBox1bil.Text + "','" + comboBox2ech.Text + "','" + textBox2quant.Text + "', '" + id.Text + "','" + comboBox1.Text + "')";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                connect.Close();
        }

        private void Moyenne()
        {
            for (int i = 0; i <= 10; i++)
            {
                comboBox1.Items.Add(i);
            }

        }
    }
}
