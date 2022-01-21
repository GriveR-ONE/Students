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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void оценкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.оценкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.students_1DataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "students_1DataSet.Оценки". При необходимости она может быть перемещена или удалена.
            this.оценкиTableAdapter.Fill(this.students_1DataSet.Оценки);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(оценка_1TextBox.Text);
            int s2 = Convert.ToInt32(оценка_2TextBox.Text);
            int s3 = Convert.ToInt32(оценка_3TextBox.Text);
            double sr = (s1 + s2 + s3) / 3;
            средний_баллTextBox.Text = Convert.ToString(sr);
        }
    }
}
