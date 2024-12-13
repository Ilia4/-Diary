using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<TaskItem> taskList = new List<TaskItem>();
        private BindingSource bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            bindingSource.DataSource = taskList;
            dataGridView1.DataSource = bindingSource;
            CustomizeGridView();
        }
        private void ClearInputFields()
        {
            tittle.Clear();
            description.Clear();
            priority.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var priorityValue = priority.SelectedItem != null ? priority.SelectedItem.ToString() : "�� ������";

            var task = new TaskItem
            {
                Title = tittle.Text,
                Description = description.Text,
                DueDate = dateTimePicker1.Value,
                Priority = priorityValue,
                IsCompleted = false
            };

            taskList.Add(task);
            UpdateTaskGrid();
            ClearInputFields();
        }
        private void CustomizeGridView()
        {
            dataGridView1.Columns["IsCompleted"].Visible = false; // �������� �������
            dataGridView1.Columns["Title"].HeaderText = "�������� ������";
            dataGridView1.Columns["Description"].HeaderText = "��������";
            dataGridView1.Columns["DueDate"].HeaderText = "�������";
            dataGridView1.Columns["Priority"].HeaderText = "���������";
        }

        private void UpdateTaskGrid()
        {
            bindingSource.ResetBindings(false); // ��������� �������
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow selectedRow in dataGridView1.SelectedRows)
                {
                    int rowIndex = selectedRow.Index;

                    if (rowIndex >= 0 && rowIndex < taskList.Count)
                    {
                        taskList.RemoveAt(rowIndex);
                    }
                }

                UpdateTaskGrid();
            }
            else
            {
                MessageBox.Show("�������� ���� �� ���� ������ ��� ��������", "��������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
