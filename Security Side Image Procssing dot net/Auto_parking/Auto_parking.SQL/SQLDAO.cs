using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace Auto_parking.SQL
{
    public class SQLDAO : SQL_Connecter
    {
        private byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
        }
        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        public void SQL_Insert(SQLDTO data)
        {
            using (var cmd = new SqlCommand("sp_insert_vao", GetConnection()))
            {  
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@RFID", SqlDbType.NChar).Value = data.RFID;
                cmd.Parameters.Add("@Bienso", SqlDbType.NChar).Value = data.Bienso;
                if(data.Hinhbiensovao == null)
                    cmd.Parameters.AddWithValue("@Hinhbiensovao", (object)DBNull.Value).SqlDbType = SqlDbType.Image;
                else
                {
                    Image Hinhbiensovao = (Image)data.Hinhbiensovao.Clone();
                    cmd.Parameters.Add("@Hinhbiensovao", SqlDbType.Image).Value = imageToByteArray(Hinhbiensovao);
                }

                if (data.Biensovao == null)
                    cmd.Parameters.AddWithValue("@Biensovao", (object)DBNull.Value).SqlDbType = SqlDbType.Image;
                else
                {
                    Image Biensovao = (Image)data.Biensovao.Clone();
                    cmd.Parameters.Add("@Biensovao", SqlDbType.Image).Value = imageToByteArray(Biensovao);
                }                
                cmd.Parameters.Add("@Vitri", SqlDbType.Int).Value = data.Vitri;
                Random rn = new Random();
                cmd.Parameters.Add("@Maxe", SqlDbType.Int).Value = rn.Next(1, 7);

                //cmd.Parameters.Add("@Hinhbiensora", SqlDbType.Image).Value = imageToByteArray(data.Hinhbiensora);

                //cmd.Parameters.Add(new SqlParameter("@BienSoXe", data.BienSoXe));
                //cmd.Parameters.Add(new SqlParameter("@HinhBienSo", data.HinhBienSo));
                //cmd.Parameters.Add(new SqlParameter("@HinhChuXe", data.HinhChuXe));
                //cmd.Parameters.Add(new SqlParameter("@ThoiGianVao", data.ThoiGianVao));
                //cmd.Parameters.Add(new SqlParameter("@ThoiGianRa", data.ThoiGianRa));
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable SQL_Select_all()
        {
            using (var cmd = new SqlCommand("sp_select_all", GetConnection()))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void SQL_delete(SQLDTO data)
        {
            //using (var cmd = new SqlCommand("delete from park1 where RFID = " + data.RFID.Substring(0,20) + " AND Tiengui = 0", GetConnection()))
            using (var cmd = new SqlCommand("delete from park1 where ID = " + data.ID.ToString(), GetConnection()))
            {
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void SQL_Select_row(ref SQLDTO data)
        {
            using (var cmd = new SqlCommand("sp_select_row", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = data.ID;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                data.RFID =  dt.Rows[0][1].ToString();
                //data.Bienso = dt.Rows[0][2].ToString();
                data.Giovao = DateTime.Parse(dt.Rows[0][5].ToString());

                MemoryStream ms = new MemoryStream((byte[])dt.Rows[0][3]);
                data.Hinhbiensovao = Image.FromStream(ms);

                ms = new MemoryStream((byte[])dt.Rows[0][8]);
                data.Biensovao = Image.FromStream(ms);

                data.Vitri = int.Parse(dt.Rows[0][9].ToString());
                data.Maxe = int.Parse(dt.Rows[0][10].ToString());
            }
        }
        public bool SQL_Select_row2(ref SQLDTO data)
        {
            using (var cmd = new SqlCommand("select ID from park1 where Vitri = " + data.Vitri +" AND Tiengui = 0", GetConnection()))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    data.ID = reader.GetInt32(0);
                }
                else
                {
                    return false;
                }
                return true;
            }
        }

        public string[] SQL_Select_android()
        {
            string[] maxe = { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" , "0"};
            using (var cmd = new SqlCommand("sp_select_android", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int lenght = dt.Rows.Count;
                for(int i = 0; i < lenght; i++)
                {
                    maxe[int.Parse(dt.Rows[i][9].ToString()) - 1] = dt.Rows[i][10].ToString();
                }
            }
            return maxe;
        }

        public string[] SQL_Select_android(out string[] bienso, out string[] mathe, out string[] giovao)
        {
            string[] maxe = { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            bienso = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            mathe = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            giovao = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            using (var cmd = new SqlCommand("sp_select_android", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int lenght = dt.Rows.Count;
                for (int i = 0; i < lenght; i++)
                {
                    maxe[int.Parse(dt.Rows[i][9].ToString()) - 1] = dt.Rows[i][10].ToString();
                    bienso[int.Parse(dt.Rows[i][9].ToString()) - 1] = dt.Rows[i][2].ToString();
                    giovao[int.Parse(dt.Rows[i][9].ToString()) - 1] = dt.Rows[i][5].ToString();
                    mathe[int.Parse(dt.Rows[i][9].ToString()) - 1] = dt.Rows[i][1].ToString();
                }
            }
            return maxe;
        }

        public int SQL_Check(ref SQLDTO data)
        {
            using (var cmd = new SqlCommand("sp_check", GetConnection()))
            {
                ////////////////////
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@RFID", SqlDbType.NVarChar, 50).Value = data.RFID;
                cmd.Parameters.Add("@exists", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@Biensoxe", SqlDbType.NVarChar, 10).Direction = ParameterDirection.Output;
                //cmd.Parameters.Add("@Giovao", SqlDbType.DateTime, 60).Direction = ParameterDirection.Output;
                //SqlDataAdapter da = new SqlDataAdapter(cmd);
                //DataTable dt = new DataTable();
                //da.Fill(dt);
                cmd.ExecuteNonQuery();
                data.Bienso = cmd.Parameters["@Biensoxe"].Value.ToString().Replace(" ","");
                //data.Giovao = DateTime.Parse(cmd.Parameters["@Giovao"].Value.ToString());
                data.ID = Convert.ToInt32(cmd.Parameters["@ID"].Value);
                return Convert.ToInt32(cmd.Parameters["@exists"].Value);
            }
        }
        public void SQL_Update(SQLDTO data)
        {
            using (var cmd = new SqlCommand("sp_update_ra", GetConnection()))
            {
                ////////////////////
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = data.ID;
                if(data.Hinhbiensora == null)
                    cmd.Parameters.AddWithValue("@Hinhbiensora", (object)DBNull.Value).SqlDbType = SqlDbType.Image;
                //cmd.Parameters.Add("@Hinhbiensora", SqlDbType.Image).Value = new byte[] { };
                else
                    cmd.Parameters.Add("@Hinhbiensora", SqlDbType.Image).Value = imageToByteArray(data.Hinhbiensora);
                cmd.Parameters.Add("@Tiengui", SqlDbType.Int).Value = data.Tiengui;

                cmd.ExecuteNonQuery();
            }
        }
        public void SQL_RESET()
        {
            using (var cmd = new SqlCommand("sp_reset", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
