using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App_3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //при нажатии кнопки данные заносятся в соответствующую табличку в БД и в datagridview
            //выводится сообщение об успешном добавлении (MessageBox)
            //поля очищаются
            textBox1.Clear();
            textBox8.Clear();
            textBox2.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            dateTimePicker1.Value = DateTime.Now;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;

            //форма закрывается
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //при нажатии кнопки данные заносятся в соответствующую табличку в БД и в datagridview
            //выводится сообщение об успешном добавлении (MessageBox)
            //поля очищаются
            textBox1.Clear();
            textBox8.Clear();
            textBox2.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            dateTimePicker1.Value = DateTime.Now;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
        }
    }
}
