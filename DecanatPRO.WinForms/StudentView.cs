using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecanatPRO.WinForms
{
    public partial class StudentView : Form, IView
    {
        public StudentView()
        {
            InitializeComponent();
        }

        public event AddDataDelegate? AddDataEvent;
        public event DeleteDataDelegate? DeleteDataEvent;

        public void RedrawForm(IEnumerable<IEnumerable<object>> data)
        {
            Students_ListView.Items.Clear();

            foreach (var item in data)
            {
                List<object> list = new List<object>(item);

                ListViewItem listViewItem = new ListViewItem(list[0].ToString() ?? string.Empty);
                listViewItem.SubItems.Add(list[1].ToString() ?? string.Empty);
                listViewItem.SubItems.Add(list[2].ToString() ?? string.Empty);

                Students_ListView.Items.Add(listViewItem);
            }
        }

        private void AddStudent_Button_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Name_TextBox.Text) ||
                string.IsNullOrWhiteSpace(Speciality_TextBox.Text) ||
                string.IsNullOrWhiteSpace(Group_TextBox.Text))
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }

            AddDataEvent?.Invoke(new List<object>()
            {
                Name_TextBox.Text.Trim(),
                Speciality_TextBox.Text.Trim(),
                Group_TextBox.Text.Trim()
            });

            Name_TextBox.Clear();
            Speciality_TextBox.Clear();
            Group_TextBox.Clear();
        }

        private void DeleteStudent_Button_Click(object? sender, EventArgs e)
        {
            if (Students_ListView.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Выберите студента в списке.");
                return;
            }

            DeleteDataEvent?.Invoke(Students_ListView.SelectedIndices[0]);
        }
    }
}
