using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SmartParking
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();

            string cs = @"Server=localhost;Port=3306;Uid=root;Pwd=password;Database=park;";

            var con = new MySqlConnection(cs);
            con.Open();

            Console.WriteLine($"MySQL version : {con.ServerVersion}");

            string q = "SELECT * FROM user";

            MySqlDataAdapter ad = new MySqlDataAdapter(q, con);
            DataSet set = new DataSet();
            ad.Fill(set, "user");
            dataGridView1.DataSource = set.Tables["user"];



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            new home().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {



            string name = textBox1.Text;
            string pass = textBox2.Text;
            string email = textBox3.Text;
            string addres = textBox4.Text;
            string VN = textBox5.Text;


            //  InharitansEmployer.employer x = new InharitansEmployer.employer();









            string commandString = "INSERT INTO user(username,password,email,Address,Vid,id) VALUES('" + name.ToString() + "','" + pass.ToString() + "','" + email.ToString() + "','" + addres.ToString() + "','" + VN.ToString() + "','" + VN.ToString() + "');";





            try

            {

                string cs = @"Server=localhost;Port=3306;Uid=root;Pwd=password;Database=park;";

                var con = new MySqlConnection(cs);
                con.Open();

                MySqlCommand sqlCommand = new MySqlCommand(commandString, con);



                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Insert In to User ");
                con.Close();



            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());

            }










        }











        private void NewUser_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

    }
}
