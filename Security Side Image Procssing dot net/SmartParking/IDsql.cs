using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartParking
{
    public partial class IDsql : Form
    {
        public IDsql()
        {
            InitializeComponent();

            ChechkVlues sky = new ChechkVlues();

                   

            label1.Text = sky.getVp();

        }

        private void IDsql_Load(object sender, EventArgs e)
        {

        }
    }
}
