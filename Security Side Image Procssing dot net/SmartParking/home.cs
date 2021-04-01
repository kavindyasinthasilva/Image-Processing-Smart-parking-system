
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SmartParking
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new NewUser().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Users\\Kavindu Yasintha\\source\\repos\\SmartParking\\Auto_parking\\Auto_parking\\bin\\Debug\\Auto_parking.exe");



        }
    }
}
