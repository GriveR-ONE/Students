using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace БД_Студенты
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void студентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.студентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.students_1DataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "students_1DataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.students_1DataSet.Студенты);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn col = new DataGridViewColumn();
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    col = dataGridViewTextBoxColumn2;
                    break;
                case 1:
                    col = dataGridViewTextBoxColumn3;
                    break;
                case 2:
                    col = dataGridViewTextBoxColumn4;
                    break;
                case 3:
                    col = dataGridViewTextBoxColumn5;
                    break;
                case 4:
                    col = dataGridViewTextBoxColumn6;
                    break;
                case 5:
                    col = dataGridViewTextBoxColumn7;
                    break;
                case 6:
                    col = dataGridViewTextBoxColumn8;
                    break;
                case 7:
                    col = dataGridViewTextBoxColumn9;
                    break;
                case 8:
                    col = dataGridViewTextBoxColumn10;
                    break;
                case 9:
                    col = dataGridViewTextBoxColumn11;
                    break;
                case 10:
                    col = dataGridViewTextBoxColumn12;
                    break;
            }
            if (radioButton1.Checked)
                студентыDataGridView.Sort(col, System.ComponentModel.ListSortDirection.Ascending);
            else
                студентыDataGridView.Sort(col, System.ComponentModel.ListSortDirection.Descending);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            студентыBindingSource.Filter = "'ФИО='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            студентыBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= студентыDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j <= студентыDataGridView.RowCount - 2; j++)
                {
                    студентыDataGridView[i, j].Style.BackColor = Color.White;
                    студентыDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i <= студентыDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j <= студентыDataGridView.RowCount - 2; j++)
                {
                    if(студентыDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        студентыDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        студентыDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
