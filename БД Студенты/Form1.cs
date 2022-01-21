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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 threeForm = new Form3();
            threeForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 fourForm = new Form4();
            fourForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 fiveForm = new Form5();
            fiveForm.Show();
        }
    }
}
