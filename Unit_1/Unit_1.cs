using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_1
{
    public partial class Unit_1 : Form
    {
        public Unit_1()
        {
            InitializeComponent();
        }

        private void btn_Tinh_Click(object sender, EventArgs e)
        {
            double a, b, c, denta, X_1, X_2;
            string Kq = "";
            a = Convert.ToDouble(txt_A.Text);
            b = Convert.ToDouble(txt_B.Text);
            c = Convert.ToDouble(txt_C.Text);

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Kq = "Phương trình đã cho có vô số nghiệm!";
                    }
                    else
                    {
                        Kq = "Phương trình đã cho vô nghiệm!";
                    }
                }
                else
                {
                    Kq = String.Format("Phương trình có nghiệm là: {0}", ((-c) / b));
                }
            }
            else
            {
                denta = b * b - 4 * a * c;
                if (denta == 0)
                {
                    Kq = String.Format("Phương trình có nghiệm kép là: {0}", ((-b) / 2 * a));
                }
                else if (denta < 0)
                {
                    Kq = "Phương trình đã cho vô nghiệm!";
                }
                else
                {
                    X_1 = (-b + Math.Sqrt(denta) / (2 * a));
                    X_2 = (-b - Math.Sqrt(denta) / (2 * a));

                    Kq = String.Format("Phương trình có nghiệm \t \n X1 =  {0} \t \n X2 = {1}", X_1, X_2);
                }
            }
            txt_KQ.Text = Kq;
        }

        private void btn_BoQua_Click(object sender, EventArgs e)
        {
            txt_A.Text = "";
            txt_B.Text = "";
            txt_C.Text = "";
            txt_KQ.Text = "";
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
