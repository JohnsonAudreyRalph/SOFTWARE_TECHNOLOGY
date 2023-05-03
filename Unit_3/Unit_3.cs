using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_3
{
    public partial class Unit_3 : Form
    {
        private List<string> allStudents = new List<string>();
        private List<string> selectedStudents = new List<string>();
        public Unit_3()
        {
            InitializeComponent();
        }
        private void RefreshLists()
        {
            /* Hiển thị danh sách sinh viên trên Listbox */
            listBoxSelectedStudents.Items.Clear();
            listBoxSelectedStudents.Items.AddRange(allStudents.ToArray());

            listBoxAllStudents.Items.Clear();
            listBoxAllStudents.Items.AddRange(selectedStudents.ToArray());
        }

        private void MoveSelectedToRight()
        {
            /* Di chuyển các sinh viên được chọn từ listbox trái qua phải */
            foreach (string student in listBoxSelectedStudents.SelectedItems)
            {
                allStudents.Remove(student);
                selectedStudents.Add(student);
            }
            RefreshLists();
        }

        private void MoveSelectedToLeft()
        {
            /* Di chuyển các sinh viên được chọn từ listbox phải qua trái */
            foreach (string student in listBoxAllStudents.SelectedItems)
            {
                selectedStudents.Remove(student);
                allStudents.Add(student);
            }
            RefreshLists();
        }

        private void MoveAllToRight()
        {
            /* Di chuyển tất cả các sinh viên từ listbox trái qua phải */
            foreach (string student in allStudents)
            {
                selectedStudents.Add(student);
            }
            allStudents.Clear();
            RefreshLists();
        }

        private void MoveAllToLeft()
        {
            /* Di chuyển tất cả các sinh viên từ listbox phải qua trái */
            foreach (string student in selectedStudents)
            {
                allStudents.Add(student);
            }
            selectedStudents.Clear();
            RefreshLists();
        }

        private void DeleteSelected()
        {
            foreach (string student in listBoxSelectedStudents.SelectedItems)
            {
                allStudents.Remove(student);
            }
            foreach (string student in listBoxAllStudents.SelectedItems)
            {
                selectedStudents.Remove(student);
            }
            RefreshLists();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoveSelectedToRight();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MoveAllToRight();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MoveSelectedToLeft();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MoveAllToLeft();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DeleteSelected();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string student = txt.Text.Trim();
                if (!string.IsNullOrEmpty(student))
                {
                    allStudents.Add(student);
                    txt.Clear();
                    RefreshLists();
                }
                e.Handled = true;
            }
        }
    }
}
