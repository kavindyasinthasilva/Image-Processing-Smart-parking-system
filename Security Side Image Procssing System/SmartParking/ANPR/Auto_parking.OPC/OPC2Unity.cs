using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Auto_parking.OPC
{
    public partial class OPC2Unity : Form
    {
        public OPC2Unity()
        {
            InitializeComponent();
        }
        public OPCdata data;

        private void OPC2Unity_Load(object sender, EventArgs e)
        {
            data = new OPCdata();
        }
        StreamWriter stream;
        StreamReader streamR;
        private bool IsCanWrite()
        {
            stream = null;
            try
            {
                stream = new StreamWriter(@"C:\Users\Quân\Documents\Unity\Third\Config.txt");
                return true;
            }
            catch (IOException)
            {
                return false;
            }
        }
        private bool IsCanRead()
        {
            streamR = null;
            try
            {
                streamR = File.OpenText(@"C:\Users\Quân\Documents\Unity\Third\Config.txt");
                return true;
            }
            catch (IOException)
            {
                return false;
            }
        }
        // light    : l1 -> l12
        // vision   : vision_hand_car, vision_inout_car;
        // posion   : si_pos_ngang, si_pos_doc, si_pos_ravao, si_pos_doc_ravao,
        // false,false,false,false,false,false,false,false,false,false,false,false|false,false|0,0,0,0
        private void timer1_Tick(object sender, EventArgs e)
        {
            string light = data.l1.ToString() +","+ data.l2.ToString() + "," + data.l3.ToString() + "," + data.l4.ToString() + "," +
                data.l5.ToString() + "," + data.l6.ToString() + "," + data.l7.ToString() + "," + data.l8.ToString() + "," +
                data.l9.ToString() + "," + data.l10.ToString() + "," + data.l11.ToString() + "," + data.l12.ToString() + "|";
            string vision = data.vision_hand_car.ToString() + "," + data.vision_in_car.ToString() + "|";
            string position = data.si_pos_ngang.ToString() + "," + data.si_pos_doc.ToString() + "," +
                data.si_pos_ravao.ToString() + "," + data.si_pos_doc_ravao;

            while (!IsCanWrite()) ;
            stream.WriteLine(light + vision + position);
            stream.Close();
        }
    }
}
