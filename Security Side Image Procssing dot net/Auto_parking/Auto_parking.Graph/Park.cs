using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Auto_parking.OPC;
using Auto_parking.SQL;
using Auto_parking;

namespace Auto_parking.Graph
{
    public partial class Park : Form
    {
        public Park(OPCdata _data)
        {
            InitializeComponent();
            data = _data;
            img[0] = Properties.Resources.car_NONE;
            img[1] = Properties.Resources.car1;
            img[2] = Properties.Resources.car2;
            img[3] = Properties.Resources.car3;
            img[4] = Properties.Resources.car4;
            img[5] = Properties.Resources.car5;
            img[6] = Properties.Resources.car6;
            img[7] = Properties.Resources.car7;
            pb_ls.Add(pictureBox10);
            pb_ls.Add(pictureBox12);
            pb_ls.Add(pictureBox13);
            pb_ls.Add(pictureBox14);
            pb_ls.Add(pictureBox15);
            pb_ls.Add(pictureBox16);
            pb_ls.Add(pictureBox17);
            pb_ls.Add(pictureBox18);
            pb_ls.Add(pictureBox19);
            pb_ls.Add(pictureBox20);
            pb_ls.Add(pictureBox21);
            pb_ls.Add(pictureBox22);
            pb_ls.Add(pictureBox23);
            tx_ls.Add(textBox1);
            tx_ls.Add(textBox2);
            tx_ls.Add(textBox3);
            tx_ls.Add(textBox4);
            tx_ls.Add(textBox5);
            tx_ls.Add(textBox6);
            tx_ls.Add(textBox7);
            tx_ls.Add(textBox8);
            tx_ls.Add(textBox9);
            tx_ls.Add(textBox10);
            tx_ls.Add(textBox11);
            tx_ls.Add(textBox12);
            tx_ls.Add(textBox13);
            bt_ls.Add(button1);
            bt_ls.Add(button2);
            bt_ls.Add(button3);
            bt_ls.Add(button4);
            bt_ls.Add(button5);
            bt_ls.Add(button6);
            bt_ls.Add(button7);
            bt_ls.Add(button8);
            bt_ls.Add(button9);
            bt_ls.Add(button10);
            bt_ls.Add(button11);
            bt_ls.Add(button12);
            bt_ls.Add(button13);
            perform_tick();
        }
        OPCdata data;
        SQLBUS bus = new SQLBUS();
        List<Button> bt_ls = new List<Button>();
        List<TextBox> tx_ls = new List<TextBox>();
        List<PictureBox> pb_ls = new List<PictureBox>();
        Image[] img = new Image[8];

        private void Park_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        public bool success = true;
        private void perform_tick()
        {
            if (success == true)
            {
                success = false;
                new Thread(() =>
                {
                    string[] bienso, mathe, giovao;
                    string[] maxe = bus.SQL_Select_android(out bienso, out mathe, out giovao);
                    for (int i = 0; i < bt_ls.Count; i++)
                    {
                        MethodInvoker mi = delegate
                        {
                            //pb_ls[i].Visible = data.getLight(i);
                            if (data.getLight(i + 1))
                            {
                                pb_ls[i].Image = img[int.Parse(maxe[i])];
                                tx_ls[i].Text = bienso[i];
                                bt_ls[i].BackColor = Color.Blue;
                            }
                            else
                            {
                                pb_ls[i].Image = img[0];
                                tx_ls[i].Text = "Empty";
                                bt_ls[i].BackColor = Color.WhiteSmoke;
                            }
                        };
                        if (InvokeRequired)
                            Invoke(mi);
                    }
                    success = true;
                }).Start();
                if (data.l_layxe)
                    button14.BackColor = Color.Blue;
                else
                    button14.BackColor = Color.WhiteSmoke;
                if (data.l_catxe)
                    button15.BackColor = Color.Blue;
                else
                    button15.BackColor = Color.WhiteSmoke;
                if (data.current_state == 0)
                    button16.BackColor = Color.Blue;
                else
                    button16.BackColor = Color.WhiteSmoke;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            perform_tick();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            SQLDTO sql = new SQLDTO();
            int vitri = bt_ls.IndexOf(b) + 1;
            if (data.l_catxe && data.l[vitri] == false && data.current_catxe == 0)
            {
                bool formclosed = false;
                BiensoXe form_bienso = new BiensoXe();
                form_bienso.Show();
                formclosed = false;
                form_bienso.FormClosing += new FormClosingEventHandler((object o, FormClosingEventArgs ex) =>
                {
                    sql.Bienso = form_bienso.textBox1.Text.ToUpper();
                    sql.RFID = DateTime.Now.ToString();
                    sql.Hinhbiensovao = null;
                    sql.Biensovao = null;
                    sql.Vitri = vitri;
                    formclosed = true;
                });
                while (!formclosed) ;
                if(bus.SQL_Insert(sql))
                    new Thread(() =>
                    {
                        data.setButton(vitri, true);
                        Thread.Sleep(100);
                        data.setButton(vitri, false);
                        Thread.Sleep(100);
                        while (data.l_catxe)
                        {
                            Thread.Sleep(100);
                            if (data.current_state == 0)
                            {
                                MessageBox.Show("Hệ thống xảy ra lỗi Warning !!!", "Thông Báo");
                                bus.SQL_delete(sql);
                                return;
                            }
                        }
                    }).Start();

            }
            else if (data.l_layxe && data.l[vitri] == true && data.current_layxe == 0)
            {
                sql.Vitri = vitri;
                if(bus.SQL_Select_row2(ref sql))
                {
                    new Thread(() =>
                    {
                        data.setButton(vitri, true);
                        Thread.Sleep(100);
                        data.setButton(vitri, false);
                        Thread.Sleep(100);
                        while (data.l_layxe)
                        {
                            Thread.Sleep(100);
                            if (data.current_state == 0)
                            {
                                MessageBox.Show("Hệ thống xảy ra lỗi Warning !!!", "Thông Báo");
                                return;
                            }
                        }
                        bus.SQL_Select_row(ref sql);
                        DateTime now = DateTime.Now;
                        TimeSpan duration = now - sql.Giovao;
                        int tien = duration.Seconds + duration.Minutes * 60 + duration.Hours * 60 * 60 + duration.Days * 60 * 60 * 24;
                        sql.Tiengui = tien;
                        sql.Hinhbiensora = null;
                        bus.SQL_Update(sql);
                    }).Start();
                }
            }
   
        }

        private void button16_Click(object sender, EventArgs e)
        {
            data.reset = true;
            Thread.Sleep(100);
            data.reset = false;
        }

        bool layxe = false;
        private void button14_Click(object sender, EventArgs e)
        {
            data.reset = true;
            Thread.Sleep(60);
            data.reset = false;
            data.Manual = false;
            data.Manual_super = false;
            Thread.Sleep(60);
            data.layxe = true;
            Thread.Sleep(60);
            data.layxe = false;
            if (!layxe)
                layxe = true;
        }

        bool catxe = false;
        private void button15_Click(object sender, EventArgs e)
        {
            data.reset = true;
            Thread.Sleep(60);
            data.reset = false;
            data.Manual = false;
            data.Manual_super = false;
            Thread.Sleep(60);
            data.catxe = true;
            Thread.Sleep(60);
            data.catxe = false;
            if (!catxe)
                catxe = true;
        }

        private void csdl_Click(object sender, EventArgs e)
        {
            Database f = new Database();
            f.Show();
        }
    }
}
