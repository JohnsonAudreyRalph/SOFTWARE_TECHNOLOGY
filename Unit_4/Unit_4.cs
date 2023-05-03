using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_4
{
    public partial class Unit_4 : Form
    {
        public Unit_4()
        {
            InitializeComponent();
            txt_Number.Focus();
            txt_Input.Enabled = false;
            txt_Output.Enabled = false;
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            int count = txt_Input.Text.Length;
            if(count < 2)
            {
                txt_Output.Text = txt_Input.Text;
                txt_Input.Text = "";
            }
            else
            {
                txt_Output.Text = "";
                // Lấy giá trị trong textbox và chuyển đổi thành mảng số nguyên
                float[] arr = Array.ConvertAll(txt_Input.Text.Split(' '), float.Parse);

                // Sắp xếp mảng theo thứ tự tăng dần
                Array.Sort(arr);

                // Hiển thị kết quả trên TextBox2
                txt_Output.Text = string.Join(", ", arr);
                txt_Input.Text = "";
            }
        }

        // Không cho phép người dùng nhập giá trị trực tiếp
        private void txt_Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_Output_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AddNumber()
        {
            string number = txt_Number.Text;
            if (number.StartsWith("0"))
            {
                number = number.TrimStart('0');
                txt_Number.Text = number;
            }
            if (int.TryParse(number, out int comm))
            {
                if (txt_Input.Text != "")
                {
                    txt_Input.Text += ", " + number;
                }
                else
                {
                    txt_Input.Text = number;
                }
                txt_Number.Clear();
                txt_Number.Focus();
            }
        }


        private void txt_Number_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddNumber();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            txt_Input.Text = "";
            txt_Output.Text = "";
        }
    }
}
