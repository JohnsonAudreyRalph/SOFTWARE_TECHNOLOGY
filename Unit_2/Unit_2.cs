using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_2
{
    public partial class Unit_2 : Form
    {
        public Unit_2()
        {
            InitializeComponent();
        }

        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AddNumber()
        {
            string number = txt_Number.Text;
            if (int.TryParse(number, out int comm))
            {
                listBox.Items.Add(comm);
                txt_Number.Clear();
                txt_Number.Focus();
            }
        }

        private void DeleteAll()
        {
            listBox.Items.Clear();
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            AddNumber();
        }

        private void txt_Number_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddNumber();
            }
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            DeleteAll();
        }
    }
}
