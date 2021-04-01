using OPCAutomation;
using System;
using System.Timers;
using System.Collections.Generic;
using System.Threading;
using System.Text;
using System.Windows.Forms;

namespace Auto_parking.OPC
{
    public class InitOPC
    {
        public bool success = true;
        public static OPCServer OPCSer = null;
        public static OPCGroups OPCGrps;
        public static OPCGroup OPCGrp;
        public static OPCItems Items;
        public static OPCItem _b1, _b2, _b3, _b4, _b5, _b6, _b7, _b8, _b9, _b10, _b11, _b12, _b13;
        public static OPCItem _l1, _l2, _l3, _l4, _l5, _l6, _l7, _l8, _l9, _l10, _l11, _l12, _l13;
        public static OPCItem _layxe, _catxe, _reset, _l_layxe, _l_catxe, _l_reset, _bottom_ravao;
        public static OPCItem _sensor, _value, _vision_hand_car, _vision_in_car, _vision_out_car;
        public static OPCItem _emer, _ngang, _doc, _vao, _ra, _b_emer, _b_ngang, _b_doc, _b_vao, _b_ra;
        public static OPCItem _bottom_ra, _bottom_vao, _bottom_ngang_r, _bottom_ngang_f, _bottom_doc_r, _bottom_doc_f, _Manual, _sensor_h, _sensor_h_1, _sensor_h_2, _Manual_super, _processing_manual;
        public static OPCItem _edit_position, _pos_ngang, _pos_doc, _current_state, _current_layxe, _current_catxe, _ex_ngang, _ex_doc_tren, _ex_doc_duoi, _si_pos_ngang, _si_pos_doc, _si_pos_ravao, _si_pos_doc_ravao, _pos_doc_ravao;
        public static OPCItem _f_ngang, _r_ngang, _f_doc, _r_doc, _f_ravao, _r_ravao, _pwm_ngang, _fr_ngang, _pwm_doc, _fr_doc, _pwm_ravao, _fr_ravao;
        public static OPCItem _biensovao, _mathevao, _giovao, _biensora, _mathera, _giovaora, _giora, _tiengui;
        public static OPCItem[] _bienso = new OPCItem[13];
        public static OPCItem[] _mathe = new OPCItem[13];
        public static OPCItem[] _giovao_ql = new OPCItem[13];
        //bool success = false;
        //System.Timers.Timer timer = null;

        void Time_out(object obj, ElapsedEventArgs e)
        {
            success = false;
            MessageBox.Show("Lỗi OPC. Reset máy please !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(0);
        }
        void CallWithTimeout(Action action, int timeoutMilliseconds)
        {
            Thread threadToKill = null;
            Action wrappedAction = () =>
            {
                threadToKill = Thread.CurrentThread;
                action();
            };

            IAsyncResult result = wrappedAction.BeginInvoke(null, null);
            if (result.AsyncWaitHandle.WaitOne(timeoutMilliseconds))
            {
                success = true;
                wrappedAction.EndInvoke(result);
            }
            else
            {
                success = false;
                threadToKill.Abort();
                //throw new TimeoutException();
            }
        }
        public InitOPC()
        {
            CallWithTimeout(Identify, 1000);
            Thread.Sleep(100);
        }
        void Identify()
        {
            OPCSer = new OPCServer();

            //timer = new System.Timers.Timer(5000);
            //timer.AutoReset = true;
            //timer.Elapsed += new ElapsedEventHandler(Time_out);
            //timer.Start();
            try
            {
                OPCSer.Connect("KEPWare.KEPServerEX.V5");
            }
            catch (Exception)
            {
                while (true) ;
            }

            if (!success)
                return;

            //timer.Dispose();
            //success = true;
            OPCGrps = OPCSer.OPCGroups;
            OPCGrp = OPCGrps.Add("A");
            string path = "Siemens2.S7-1200.";
            Items = OPCGrp.OPCItems;

            _biensovao = Items.AddItem(path + "biensovao", 1);
            _mathevao = Items.AddItem(path + "mathevao", 1);
            _giovao = Items.AddItem(path + "giovao", 1);
            _biensora = Items.AddItem(path + "biensora", 1);
            _mathera = Items.AddItem(path + "mathera", 1);
            _giovaora = Items.AddItem(path + "giovaora", 1);
            _giora = Items.AddItem(path + "giora", 1);
            _tiengui = Items.AddItem(path + "tiengui", 1);

            for(int i = 0; i<_bienso.Length; i++)
            {
                _bienso[i] = Items.AddItem(path + "bienso" + (i + 1).ToString(), 1);
                _mathe[i] = Items.AddItem(path + "mathe" + (i + 1).ToString(), 1);
                _giovao_ql[i] = Items.AddItem(path + "giovao" + (i + 1).ToString(), 1);
            }

            _b1 = Items.AddItem(path + "buttom.1", 1);
            _b2 = Items.AddItem(path + "buttom.2", 1);
            _b3 = Items.AddItem(path + "buttom.3", 1);
            _b4 = Items.AddItem(path + "buttom.4", 1);
            _b5 = Items.AddItem(path + "buttom.5", 1);
            _b6 = Items.AddItem(path + "buttom.6", 1);
            _b7 = Items.AddItem(path + "buttom.7", 1);
            _b8 = Items.AddItem(path + "buttom.8", 1);
            _b9 = Items.AddItem(path + "buttom.9", 1);
            _b10 = Items.AddItem(path + "buttom.10", 1);
            _b11 = Items.AddItem(path + "buttom.11", 1);
            _b12 = Items.AddItem(path + "buttom.12", 1);
            _b13 = Items.AddItem(path + "buttom.13", 1);

            _l1 = Items.AddItem(path + "buttom.l_1", 1);
            _l2 = Items.AddItem(path + "buttom.l_2", 1);
            _l3 = Items.AddItem(path + "buttom.l_3", 1);
            _l4 = Items.AddItem(path + "buttom.l_4", 1);
            _l5 = Items.AddItem(path + "buttom.l_5", 1);
            _l6 = Items.AddItem(path + "buttom.l_6", 1);
            _l7 = Items.AddItem(path + "buttom.l_7", 1);
            _l8 = Items.AddItem(path + "buttom.l_8", 1);
            _l9 = Items.AddItem(path + "buttom.l_9", 1);
            _l10 = Items.AddItem(path + "buttom.l_10", 1);
            _l11 = Items.AddItem(path + "buttom.l_11", 1);
            _l12 = Items.AddItem(path + "buttom.l_12", 1);
            _l13 = Items.AddItem(path + "buttom.l_13", 1);

            _layxe = Items.AddItem(path + "buttom.layxe", 1);
            _catxe = Items.AddItem(path + "buttom.catxe", 1);
            _reset = Items.AddItem(path + "buttom.reset", 1);
            _l_layxe = Items.AddItem(path + "buttom.l_layxe", 1);
            _l_catxe = Items.AddItem(path + "buttom.l_catxe", 1);
            _l_reset = Items.AddItem(path + "buttom.l_reset", 1);
            _bottom_ravao = Items.AddItem(path + "buttom.bottom_ravao", 1);

            _sensor = Items.AddItem(path + "HMI.sensor", 1);
            _value = Items.AddItem(path + "HMI.value", 1);
            _vision_hand_car = Items.AddItem(path + "HMI.vision_hand_car", 1);
            _vision_out_car = Items.AddItem(path + "HMI.vision_out_car", 1);
            _vision_in_car = Items.AddItem(path + "HMI.vision_in_car", 1);

            _emer = Items.AddItem(path + "input.emer", 1);
            _ngang = Items.AddItem(path + "input.ngang", 1);
            _doc = Items.AddItem(path + "input.doc", 1);
            _vao = Items.AddItem(path + "input.vao", 1);
            _ra = Items.AddItem(path + "input.ra", 1);
            _b_emer = Items.AddItem(path + "input.b_emer", 1);
            _b_ngang = Items.AddItem(path + "input.b_ngang", 1);
            _b_doc = Items.AddItem(path + "input.b_doc", 1);
            _b_vao = Items.AddItem(path + "input.b_vao", 1);
            _b_ra = Items.AddItem(path + "input.b_ra", 1);

            _bottom_ra = Items.AddItem(path + "manual.bottom_ra", 1);
            _bottom_vao = Items.AddItem(path + "manual.bottom_vao", 1);
            _bottom_ngang_r = Items.AddItem(path + "manual.bottom_ngang_r", 1);
            _bottom_ngang_f = Items.AddItem(path + "manual.bottom_ngang_f", 1);
            _bottom_doc_r = Items.AddItem(path + "manual.bottom_doc_r", 1);
            _bottom_doc_f = Items.AddItem(path + "manual.bottom_doc_f", 1);
            _Manual = Items.AddItem(path + "manual.Manual", 1);
            _sensor_h = Items.AddItem(path + "manual.sensor_h", 1);
            _sensor_h_1 = Items.AddItem(path + "manual.sensor_h_1", 1);
            _sensor_h_2 = Items.AddItem(path + "manual.sensor_h_2", 1);
            _Manual_super = Items.AddItem(path + "manual.Manual_super", 1);
            _processing_manual = Items.AddItem(path + "manual.processing_manual", 1);

            _edit_position = Items.AddItem(path + "menory.edit_position", 1);
            _pos_ngang = Items.AddItem(path + "menory.pos_ngang", 1);
            _pos_doc = Items.AddItem(path + "menory.pos_doc", 1);
            _current_state = Items.AddItem(path + "menory.current_state", 1);
            _current_layxe = Items.AddItem(path + "menory.current_layxe", 1);
            _current_catxe = Items.AddItem(path + "menory.current_catxe", 1);
            _ex_ngang = Items.AddItem(path + "menory.ex_ngang", 1);
            _ex_doc_tren = Items.AddItem(path + "menory.ex_doc_tren", 1);
            _ex_doc_duoi = Items.AddItem(path + "menory.ex_doc_duoi", 1);
            _si_pos_ngang = Items.AddItem(path + "menory.si_pos_ngang", 1);
            _si_pos_doc = Items.AddItem(path + "menory.si_pos_doc", 1);
            _si_pos_ravao = Items.AddItem(path + "menory.si_pos_ravao", 1);
            _si_pos_doc_ravao = Items.AddItem(path + "menory.si_pos_doc_ravao", 1);
            _pos_doc_ravao = Items.AddItem(path + "menory.pos_doc_ravao", 1);

            _f_ngang = Items.AddItem(path + "output.f_ngang", 1);
            _r_ngang = Items.AddItem(path + "output.r_ngang", 1);
            _f_doc = Items.AddItem(path + "output.f_doc", 1);
            _r_doc = Items.AddItem(path + "output.r_doc", 1);
            _f_ravao = Items.AddItem(path + "output.f_ravao", 1);
            _r_ravao = Items.AddItem(path + "output.r_ravao", 1);
            _pwm_ngang = Items.AddItem(path + "output.pwm_ngang", 1);
            _fr_ngang = Items.AddItem(path + "output.fr_ngang", 1);
            _pwm_doc = Items.AddItem(path + "output.pwm_doc", 1);
            _fr_doc = Items.AddItem(path + "output.fr_doc", 1);
            _pwm_ravao = Items.AddItem(path + "output.pwm_ravao", 1);
            _fr_ravao = Items.AddItem(path + "output.fr_ravao", 1);

            OPCGrp.UpdateRate = 100;
            OPCGrp.IsActive = true;
            OPCGrp.IsSubscribed = true;

            //object v;
            //object q;
            //object t;
            //Item1.Read((short)OPCDataSource.OPCCache, out v, out q, out t);
        }
    }
}
