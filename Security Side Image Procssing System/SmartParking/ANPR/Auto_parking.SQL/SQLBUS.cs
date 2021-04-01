using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Threading.Tasks;


namespace Auto_parking.SQL
{
    public class SQLBUS
    {
        private SQLDAO db;

        public SQLBUS()
        {
            db = new SQLDAO();
        }

        public bool SQL_Insert(SQLDTO data)
        {
            bool sucess = false;
            try
            {
                db.SQL_Insert(data);
                sucess = true;
            }
            catch( Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi khi chèn dữ liệu! \n\r error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sucess = false;
                //throw e;
            }
            return sucess;
        }

        public DataTable SQL_Select_all()
        {
            try
            {
                return db.SQL_Select_all();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi ở SQL_Select_all! \n\r error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
                //throw e;
            }
        }
        public void SQL_delete(SQLDTO data)
        {
            try
            {
                db.SQL_delete(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi ở SQL_delete! \n\r error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw e;
            }
        }
        public void SQL_Select_row(ref SQLDTO data)
        {
            try
            {
                db.SQL_Select_row(ref data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi ở SQL_Select_row! \n\r error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                //throw e;
            }
        }

        public bool SQL_Select_row2(ref SQLDTO data)
        {
            try
            {
                return db.SQL_Select_row2(ref data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi ở SQL_Select_row2! \n\r error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                //throw e;
            }
        }

        public string[] SQL_Select_android()
        {
            try
            {
                return db.SQL_Select_android();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi ở SQL_Select_android! \n\r error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw e;
            }
            return null;
        }

        public string[] SQL_Select_android(out string[] bienso, out string[] mathe, out string[] giovao)
        {
            bienso = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            mathe = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            giovao = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            try
            {
                string [] maxe = db.SQL_Select_android(out bienso, out mathe, out giovao);
                return maxe;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi ở SQL_Select_android2! \n\r error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw e;
            }
            return null;
        }

        public int SQL_Check(ref SQLDTO data)
        {
            try
            {
                return db.SQL_Check(ref data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi khi Check! \n\r error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            
        }

        public void SQL_Update(SQLDTO data)
        {
            try
            {
                db.SQL_Update(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi khi update! \n\r error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void SQL_RESET()
        {
            try
            {
                db.SQL_RESET();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi khi Reset! \n\r error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
