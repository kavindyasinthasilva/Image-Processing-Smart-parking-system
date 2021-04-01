using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OPCAutomation;

namespace Auto_parking.OPC
{
    public class OPCdata : InitOPC
    {

        public OPCdata()
        {
            buttom[1] = _b1;
            buttom[2] = _b2;
            buttom[3] = _b3;
            buttom[4] = _b4;
            buttom[5] = _b5;
            buttom[6] = _b6;
            buttom[7] = _b7;
            buttom[8] = _b8;
            buttom[9] = _b9;
            buttom[10] = _b10;
            buttom[11] = _b11;
            buttom[12] = _b12;
            buttom[13] = _b13;
            light[1] = _l1;
            light[2] = _l2;
            light[3] = _l3;
            light[4] = _l4;
            light[5] = _l5;
            light[6] = _l6;
            light[7] = _l7;
            light[8] = _l8;
            light[9] = _l9;
            light[10] = _l10;
            light[11] = _l11;
            light[12] = _l12;
            light[13] = _l12;
            for (int i = 0; i < _bienso.Length; i++)
            {
                bienso[i] = _bienso[i];
            }
        }
        private OPCItem[] light = new OPCItem[14];
        private OPCItem[] buttom = new OPCItem[14];
        private OPCItem[] bienso = new OPCItem[13];
        object v;
        object q;
        object t;
        public void setbienso(string s, int i)
        {
            bienso[i - 1].Write(s);
        }
        public void setgiovao(string s, int i)
        {
            _giovao_ql[i - 1].Write(s);
        }
        public void setmathe(string s, int i)
        {
            _mathe[i - 1].Write(s);
        }
        public void biensovao(string s)
        {
            _biensovao.Write(s);
        }
        public void mathevao(string s)
        {
            _mathevao.Write(s);
        }
        public void giovao(string s)
        {
            _giovao.Write(s);
        }
        public void biensora(string s)
        {
            _biensora.Write(s);
        }
        public void mathera(string s)
        {
            _mathera.Write(s);
        }
        public void giovaora(string s)
        {
            _giovaora.Write(s);
        }
        public void giora(string s)
        {
            _giora.Write(s);
        }
        public void tiengui(string s)
        {
            _tiengui.Write(s);
        }
        public string status
        {
            get
            {
                _b1.Read((short)OPCDataSource.OPCCache, out v, out q, out t);
                if (int.Parse(q.ToString()) == 192)
                    return "GOOD";
                else
                    return "BAD";
            }
        }
        public string lastupdate
        {
            get
            {
                _b1.Read((short)OPCDataSource.OPCCache, out v, out q, out t);
                return t.ToString();
            }
        }
        private bool getBool(OPCItem item)
        {
            item.Read((short)OPCDataSource.OPCCache, out v, out q, out t);
            try
            {
                return bool.Parse(v.ToString());
            }
            catch (Exception)
            {
                return false;
            }
        }
        private int getInt(OPCItem item)
        {
            item.Read((short)OPCDataSource.OPCCache, out v, out q, out t);
            try
            {
                return int.Parse(v.ToString());
            }
            catch (Exception)
            {
                return 0;
            }
        }
        private double getDouble(OPCItem item)
        {
            item.Read((short)OPCDataSource.OPCCache, out v, out q, out t);
            try
            {
                return double.Parse(v.ToString());
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public bool[] l
        {
            get
            {
                bool[] output = new bool[14];
                output[1] = l1;
                output[2] = l2;
                output[3] = l3;
                output[4] = l4;
                output[5] = l5;
                output[6] = l6;
                output[7] = l7;
                output[8] = l8;
                output[9] = l9;
                output[10] = l10;
                output[11] = l11;
                output[12] = l12;
                output[13] = l12;
                return output;
            }
        }
        
        public void setButton(int i, bool value)
        {
            buttom[i].Write(value);
        }
        public bool getLight(int i)
        {
            return getBool(light[i]);
        }
        #region b1 -> b12

        public bool b1
        {
            get
            {
                return getBool(_b1);
            }
            set
            {
                _b1.Write(value);
            }
        }
        public bool b2
        {
            get
            {
                return getBool(_b2);
            }
            set
            {
                _b2.Write(value);
            }
        }
        public bool b3
        {
            get
            {
                return getBool(_b3);
            }
            set
            {
                _b3.Write(value);
            }
        }
        public bool b4
        {
            get
            {
                return getBool(_b4);
            }
            set
            {
                _b4.Write(value);
            }
        }
        public bool b5
        {
            get
            {
                return getBool(_b5);
            }
            set
            {
                _b5.Write(value);
            }
        }
        public bool b6
        {
            get
            {
                return getBool(_b6);
            }
            set
            {
                _b6.Write(value);
            }
        }
        public bool b7
        {
            get
            {
                return getBool(_b7);
            }
            set
            {
                _b7.Write(value);
            }
        }
        public bool b8
        {
            get
            {
                return getBool(_b8);
            }
            set
            {
                _b8.Write(value);
            }
        }
        public bool b9
        {
            get
            {
                return getBool(_b9);
            }
            set
            {
                _b9.Write(value);
            }
        }
        public bool b10
        {
            get
            {
                return getBool(_b10);
            }
            set
            {
                _b10.Write(value);
            }
        }
        public bool b11
        {
            get
            {
                return getBool(_b11);
            }
            set
            {
                _b11.Write(value);
            }
        }
        public bool b12
        {
            get
            {
                return getBool(_b12);
            }
            set
            {
                _b12.Write(value);
            }
        }
        public bool b13
        {
            get
            {
                return getBool(_b13);
            }
            set
            {
                _b13.Write(value);
            }
        }
        public bool b_inout
        {
            get
            {
                return getBool(_bottom_ravao);
            }
            set
            {
                _bottom_ravao.Write(value);
            }
        }
        #endregion

        #region l1 -> l12
        public bool l1
        {
            get
            {
                return getBool(_l1);
            }
        }
        public bool l2
        {
            get
            {
                return getBool(_l2);
            }
        }
        public bool l3
        {
            get
            {
                return getBool(_l3);
            }
        }
        public bool l4
        {
            get
            {
                return getBool(_l4);
            }
        }
        public bool l5
        {
            get
            {
                return getBool(_l5);
            }
        }
        public bool l6
        {
            get
            {
                return getBool(_l5);
            }
        }
        public bool l7
        {
            get
            {
                return getBool(_l7);
            }
        }
        public bool l8
        {
            get
            {
                return getBool(_l8);
            }
        }
        public bool l9
        {
            get
            {
                return getBool(_l9);
            }
        }
        public bool l10
        {
            get
            {
                return getBool(_l10);
            }
        }
        public bool l11
        {
            get
            {
                return getBool(_l11);
            }
        }
        public bool l12
        {
            get
            {
                return getBool(_l12);
            }
        }
        public bool l13
        {
            get
            {
                return getBool(_l13);
            }
        }
        #endregion

        #region layxe, catxe, reset, l_layxe, l_catxe, l_reset;
        public bool layxe
        {
            get
            {
                return getBool(_layxe);
            }
            set
            {
                _layxe.Write(value);
            }
        }
        public bool catxe
        {
            get
            {
                return getBool(_catxe);
            }
            set
            {
                _catxe.Write(value);
            }
        }
        public bool reset
        {
            get
            {
                return getBool(_reset);
            }
            set
            {
                _reset.Write(value);
            }
        }
        public bool l_layxe
        {
            get
            {
                return getBool(_l_layxe);
            }
        }
        public bool l_catxe
        {
            get
            {
                return getBool(_l_catxe);
            }
        }
        public bool l_reset
        {
            get
            {
                return getBool(_l_reset);
            }
    }
    #endregion

    #region sensor, value, vision_hand_car, vision_in_car, vision_out_car;
    public bool sensor
        {
            get
            {
                return getBool(_sensor);
            }
        }
        public bool value
        {
            get
            {
                return getBool(_value);
            }
        }
        public bool vision_hand_car
        {
            get
            {
                return getBool(_vision_hand_car);
            }
        }
        public bool vision_in_car
        {
            get
            {
                return getBool(_vision_in_car);
            }
        }
        public bool vision_out_car
        {
            get
            {
                return getBool(_vision_out_car);
            }
        }
        #endregion

        #region emer, ngang, doc, vao, ra, b_emer, b_ngang, b_doc, b_vao, b_ra;
        public bool emer
        {
            get
            {
                return getBool(_emer);
            }
        }
        public bool ngang
        {
            get
            {
                return getBool(_ngang);
            }
        }
        public bool doc
        {
            get
            {
                return getBool(_doc);
            }
        }
        public bool vao
        {
            get
            {
                return getBool(_vao);
            }
        }
        public bool ra
        {
            get
            {
                return getBool(_ra);
            }
        }
        public bool b_emer
        {
            get
            {
                return getBool(_b_emer);
            }
            set
            {
                _b_emer.Write(value);
            }
        }
        public bool b_ngang
        {
            get
            {
                return getBool(_b_ngang);
            }
        }
        public bool b_doc
        {
            get
            {
                return getBool(_b_doc);
            }
        }
        public bool b_vao
        {
            get
            {
                return getBool(_b_vao);
            }
        }
        public bool b_ra
        {
            get
            {
                return getBool(_b_ra);
            }
        }
        #endregion

        #region bottom_ra, bottom_vao, bottom_ngang_r, bottom_ngang_f, bottom_doc_r, bottom_doc_f, Manual, sensor_h, sensor_h_1, sensor_h_2;
        public bool bottom_ra
        {
            get
            {
                return getBool(_bottom_ra);
            }
            set
            {
                _bottom_ra.Write(value);
            }
        }
        public bool bottom_vao
        {
            get
            {
                return getBool(_bottom_vao);
            }
            set
            {
                _bottom_vao.Write(value);
            }
        }
        public bool bottom_ngang_r
        {
            get
            {
                return getBool(_bottom_ngang_r);
            }
            set
            {
                _bottom_ngang_r.Write(value);
            }
        }
        public bool bottom_ngang_f
        {
            get
            {
                return getBool(_bottom_ngang_f);
            }
            set
            {
                _bottom_ngang_f.Write(value);
            }
        }
        public bool bottom_doc_r
        {
            get
            {
                return getBool(_bottom_doc_r);
            }
            set
            {
                _bottom_doc_r.Write(value);
            }
        }
        public bool bottom_doc_f
        {
            get
            {
                return getBool(_bottom_doc_f);
            }
            set
            {
                _bottom_doc_f.Write(value);
            }
        }
        public bool Manual
        {
            get
            {
                return getBool(_Manual);
            }
            set
            {
                _Manual.Write(value);
            }
        }
        public bool sensor_h
        {
            get
            {
                return getBool(_sensor_h);
            }
        }
        public bool sensor_h_1
        {
            get
            {
                return getBool(_sensor_h_1);
            }
        }
        public bool sensor_h_2
        {
            get
            {
                return getBool(_sensor_h_2);
            }
        }
        public bool Manual_super
        {
            get
            {
                return getBool(_Manual_super);
            }
            set
            {
                _Manual_super.Write(value);
            }
        }
        public bool Processing_manual
        {
            get
            {
                return getBool(_processing_manual);
            }
        }
        #endregion

        #region pos_ngang, pos_doc, current_state, current_layxe, current_catxe, ex_ngang, ex_doc_tren, ex_doc_duoi, si_pos_ngang, si_pos_doc, si_pos_ravao, si_pos_doc_ravao, pos_doc_ravao;

        public bool edit_position
        {
            get
            {
                return getBool(_edit_position);
            }
            set
            {
                
                _edit_position.Write(value);
            }
        }
        public int pos_ngang
        {
            get
            {
                return getInt(_pos_ngang);
            }
            set
            {
                _pos_ngang.Write(value);
            }
        }
        public int pos_doc
        {
            get
            {
                return getInt(_pos_doc);
            }
            set
            {
                _pos_doc.Write(value);
            }
        }
        public int current_state
        {
            get
            {
                return getInt(_current_state);
            }
        }
        public int current_layxe
        {
            get
            {
                return getInt(_current_layxe);
            }
        }
        public int current_catxe
        {
            get
            {
                return getInt(_current_catxe);
            }
        }
        public int ex_ngang
        {
            get
            {
                return getInt(_ex_ngang);
            }
        }
        public int ex_doc_tren
        {
            get
            {
                return getInt(_ex_doc_tren);
            }
        }
        public int ex_doc_duoi
        {
            get
            {
                return getInt(_ex_doc_duoi);
            }
        }
        public double si_pos_ngang
        {
            get
            {
                if(getDouble(_si_pos_ngang) < 4294967295 / 2)
                {
                    return getDouble(_si_pos_ngang);
                }
                else
                {
                    return (getDouble(_si_pos_ngang) - 4294967295 - 1);
                }   
            }
        }
        public double si_pos_doc
        {
            get
            {
                _si_pos_doc.Read((short)OPCDataSource.OPCCache, out v, out q, out t);
                if (getDouble(_si_pos_doc) < 4294967295 / 2)
                {
                    return getDouble(_si_pos_doc);
                }
                else
                {
                    return (getDouble(_si_pos_doc) - 4294967295 - 1);
                }
            }
        }
        public double si_pos_ravao
        {
            get
            {
                if (getDouble(_si_pos_ravao) < 4294967295 / 2)
                {
                    return getDouble(_si_pos_ravao);
                }
                else
                {
                    return (getDouble(_si_pos_ravao) - 4294967295 - 1);
                }
            }
        }
        public double si_pos_doc_ravao
        {
            get
            {
                if (getDouble(_si_pos_doc_ravao) < 4294967295 / 2)
                {
                    return getDouble(_si_pos_doc_ravao);
                }
                else
                {
                    return (getDouble(_si_pos_doc_ravao) - 4294967295 - 1);
                }
            }
        }
        public int pos_doc_ravao
        {
            get
            {
                return getInt(_pos_doc_ravao);
            }
            set
            {
                _pos_doc_ravao.Write(value);
            }
        }
        #endregion

        #region f_ngang, r_ngang, f_doc, r_doc, f_ravao, r_ravao, pwm_ngang, fr_ngang, pwm_doc, fr_doc, pwm_ravao, fr_ravao;
        public bool f_ngang
        {
            get
            {
                return getBool(_f_ngang);
            }
        }
        public bool r_ngang
        {
            get
            {
                return getBool(_r_ngang);
            }
        }
        public bool f_doc
        {
            get
            {
                return getBool(_f_doc);
            }
        }
        public bool r_doc
        {
            get
            {
                return getBool(_r_doc);
            }
        }
        public bool f_ravao
        {
            get
            {
                return getBool(_f_ravao);
            }
        }
        public bool r_ravao
        {
            get
            {
                return getBool(_r_ravao);
            }
        }
        public bool pwm_ngang
        {
            get
            {
                return getBool(_pwm_ngang);
            }
        }
        public bool fr_ngang
        {
            get
            {
                return getBool(_fr_ngang);
            }
        }
        public bool pwm_doc
        {
            get
            {
                return getBool(_pwm_doc);
            }
        }
        public bool fr_doc
        {
            get
            {
                return getBool(_fr_doc);
            }
        }
        public bool pwm_ravao
        {
            get
            {
                return getBool(_pwm_ravao);
            }
        }
        public bool fr_ravao
        {
            get
            {
                return getBool(_fr_doc);
            }
        }
        #endregion
    }
}
