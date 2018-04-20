
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
    public partial class Form3 : Form
    {

        public static SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CECILE\Documents\ppe3\ppe3\pratic.mdf;Integrated Security=True");
        public bool request = true;
        public Form3()
        {
            InitializeComponent();
        }

        private void retourcr_Click(object sender, EventArgs e)
        {
            Form2 openForm = new Form2();
            openForm.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Moyenne();
            Prtc();
            Mdcmt();
            this.user.Text = Form1.username2;
            this.user.Hide();
            this.id.Text = Form1.iduser;
            this.id.Hide();
        }

        public void Prtc()
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

        public void Mdcmt()
        {
            comboBoxechantillon.Items.Clear();
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
                comboBoxechantillon.Items.Add(dr["nom"].ToString());
            }



            connect.Close();
        }

        public void FormInsert()
        {
             connect.Open();
             SqlCommand cmd = connect.CreateCommand();
             cmd.CommandType = CommandType.Text;
             cmd.CommandText = "Insert into CompteRendu(date, docteur, motif, bilan, echantillon, quantité, Id_visiteur, note) values ('"
                 + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + comboBoxmedecin.Text + "','" + textBoxmotif.Text + "','"
                 + richTextBoxbilan.Text + "','" + comboBoxechantillon.Text + "','" + textBoxquantite.Text + "', '" + id.Text + "','" + comboBox1.Text + "')";
             DataTable dt = new DataTable();
             SqlDataAdapter da = new SqlDataAdapter(cmd);
             da.Fill(dt);
             connect.Close();

        }
        
    

        private void ajoutercr_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || textBoxmotif.Text == "" || textBoxquantite.Text == "" || richTextBoxbilan.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
            else
            {
                FormInsert();
                this.Hide();
                Form2 openform = new Form2();
                openform.Show();
            }
        }

        private void Moyenne()
        {
            for (int i = 0; i <= 10; i++)
            {
                comboBox1.Items.Add(i);
            }
            
        }

        private void checkBoxrmplacant_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxmedecin.Items.Clear();
            connect.Open();
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select nom From Remplacant";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBoxmedecin.Items.Add(dr["nom"].ToString());
            }


        
        }
    }
}
 