using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Auto_parking.SQL;

namespace Auto_parking
{
    public partial class Database : Form
    {
        public Database()
        {
            InitializeComponent();
        }

        SQLBUS sql = new SQLBUS();
        private void timer1_Tick(object sender, EventArgs e)
        {
            DataTable dt = sql.SQL_Select_all();
            if (dataGridView1.RowCount - 1 != dt.Rows.Count)
                dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView grid = (DataGridView)sender;
                textBox1.Text = grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox2.Text = grid.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox3.Text = grid.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox4.Text = grid.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            catch (Exception) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLDTO data = new SQLDTO();
            //data.RFID = textBox3.Text;
            data.ID = int.Parse(textBox1.Text);
            sql.SQL_delete(data);
        }
    }
}
