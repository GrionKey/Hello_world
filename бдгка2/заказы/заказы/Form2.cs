using System;
using System.Windows.Forms;

namespace заказы
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  // Кнопка подтвердить
        {
            if (comboBox1.Text == "Admonistrator")  // Логин
            {
                if (textBox1.Text == "0000")    // Пароль
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("Input error"); // Пароль неверный
                    textBox1.Focus();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)  // Кнопка выход
        {
            Application.Exit();
        }
    }
}
