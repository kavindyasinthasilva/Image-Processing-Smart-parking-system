using ComputerToArduino;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartParking
{
   public class ChechkVlues
    {

        public String Vp;



        public ChechkVlues()
        {



        }


        public ChechkVlues(string x)
        {
           
          

          this.Vp = x;
          MessageBox.Show(Vp);

          

           

            string cs = @"server=localhost;userid=root;password=;database=ipparking";

            var con = new MySqlConnection(cs);
            con.Open();

            Console.WriteLine($"MySQL version : {con.ServerVersion}");



            MySqlCommand cmd = new MySqlCommand("select Vnumber from parkingoder where username='" + Vp + "'", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("This Number has Our Db");
              

                new Form2().Show();
            }
            else
            {
                new Form2().Show();
            }
            con.Close();





        }

        public String getVp()
        {



          return Vp; 


        }


    }
}
