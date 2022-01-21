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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void студентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.студентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.students_1DataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "students_1DataSet1.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.students_1DataSet1.Студенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "students_1DataSet1.Специальности". При необходимости она может быть перемещена или удалена.
            this.специальностиTableAdapter.Fill(this.students_1DataSet1.Специальности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "students_1DataSet1.Специальности". При необходимости она может быть перемещена или удалена.
            this.специальностиTableAdapter.Fill(this.students_1DataSet1.Специальности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "students_1DataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.students_1DataSet.Студенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "students_1DataSet.Специальности". При необходимости она может быть перемещена или удалена.
            this.специальностиTableAdapter.Fill(this.students_1DataSet.Специальности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "students_1DataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.students_1DataSet.Студенты);

        }

        private void полTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            студентыBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            студентыBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            студентыBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            студентыBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            студентыBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            студентыBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.студентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.students_1DataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form6 TblForm = new Form6();
            TblForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form7 RepForm = new Form7();
            RepForm.Show();
        }
    }
}
