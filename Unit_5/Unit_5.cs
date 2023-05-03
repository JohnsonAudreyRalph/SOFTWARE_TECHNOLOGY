using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_5
{
    public partial class Unit_5 : Form
    {
        public Unit_5()
        {
            InitializeComponent();
            btnExit.Enabled = true;
            btnSearch.Enabled = false;
            btnReplace.Enabled = false;
            txtValue.Enabled = false;
            txt_Result.Enabled = false;
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (txtValue.TextLength > 0)
            {
                // Cho phép sử dụng các nút chức năng nếu đã nhập dữ liệu
                btnSearch.Enabled = true;
                btnReplace.Enabled = true;
            }
            else
            {
                // Không cho phép sử dụng các nút chức năng nếu chưa nhập dữ liệu
                btnSearch.Enabled = false;
                btnReplace.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string inputString = txtValue.Text;
            string searchString = txtSearch.Text;

            // Tìm kiếm chuỗi searchString trong inputString
            int result = inputString.IndexOf(searchString, StringComparison.OrdinalIgnoreCase);

            if (result != -1)
            {
                txt_Result.Text = $"Tìm thấy chuỗi '{searchString}' ở vị trí {result + 1}.";
            }
            else
            {
                txt_Result.Text = $"Không tìm thấy chuỗi '{searchString}' trong chuỗi đã nhập.";
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string inputString = txtValue.Text;
            string searchString = txtSearch.Text;
            string replaceString = txtReplace.Text;

            // Thay thế chuỗi searchString bằng chuỗi replaceString trong inputString
            string result = inputString.Replace(searchString, replaceString);

            txt_Result.Text = $"Chuỗi sau khi thay thế: {result}";
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtValue.Text = txtInput.Text;
                txtInput.Text = "";
                txtInput.Focus();
            }
        }
    }
}
