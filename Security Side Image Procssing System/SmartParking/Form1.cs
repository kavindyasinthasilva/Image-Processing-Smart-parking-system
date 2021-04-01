using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SmartParking
{
    public partial class Form1 : Form


    {



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kavindu Yasintha\Documents\parking.mdf;Integrated Security=True;Connect Timeout=30");

            string user = textBox1.Text;
            string pass = textBox2.Text;





            con.Open();





            SqlCommand cmd = new SqlCommand("select username,password from  Login where username='" + user + "'and password='" + pass + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login sucess Welcome to Admin Panal");
                this.Hide();

                new home().Show();
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();





        }












    }
}

