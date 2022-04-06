using System;
using System.Windows.Forms;

namespace заказы
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void заказчикBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказчикBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.заказыDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.заказыDataSet.Заказы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.Заказчик". При необходимости она может быть перемещена или удалена.
            this.заказчикTableAdapter.Fill(this.заказыDataSet.Заказчик);

        }

        private void Form1_Shown(object sender, EventArgs e)    // открытие 2ой формы при запуске программы
        {
            Form2 form2 = new Form2();
            form2.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e) // очитска полей ввода данных 1
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        

        private void button5_Click(object sender, EventArgs e) // очитска полей ввода данных 2
        {
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
        }

        private void button7_Click(object sender, EventArgs e)  // Кнопка "Запрос"
        {
            string Stat = "";
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Stat = "Оплачен";
                    break;
                case 1:
                    Stat = "Неоплачен";
                    break;
            }
            this.заказчикTableAdapter.FillBy(this.заказыDataSet.Заказчик, Stat);
        }

        private void button8_Click(object sender, EventArgs e)  // Кнопка "Сброс"
        {
            this.заказчикTableAdapter.Fill(this.заказыDataSet.Заказчик);
        }

        private void button1_Click(object sender, EventArgs e)  // Внесение данных в таблицу "Заказчик"
        {
            string
                A1 = textBox1.Text, // Имя
                A2 = textBox2.Text, // Фамилия
                A3 = textBox3.Text; // Статус заказа

            int A4 = Convert.ToInt32(textBox4.Text); // Номер заказа
            this.заказчикTableAdapter.InsertQuery(A1, A2, A3, A4);
            this.заказчикTableAdapter.Fill(this.заказыDataSet.Заказчик);
        }

        private void button2_Click(object sender, EventArgs e)  // Изменение данных в таблице "Заказчик"
        {
            string
                A1 = textBox1.Text, // Имя
                A2 = textBox2.Text, // Фамилия
                A3 = textBox3.Text; // Статус заказа

            int A4 = Convert.ToInt32(textBox4.Text),            // Номер заказа
                CodeP = Convert.ToInt32(textBox5.Text);         // КодП
            this.заказчикTableAdapter.UpdateQuery(A1, A2, A3, A4, CodeP);
            this.заказчикTableAdapter.Fill(this.заказыDataSet.Заказчик);
        }

        private void button4_Click(object sender, EventArgs e)  // Внесение данных в таблицу "Заказы"
        {
            string
                A1 = textBox6.Text, // Наименование
                A2 = textBox7.Text, // Цена
                A3 = textBox8.Text; // Город
            int
                A4 = Convert.ToInt32(textBox9.Text),    // Артикул
                A5 = Convert.ToInt32(textBox10.Text);   // КодЗ
            this.заказыTableAdapter.InsertQuery2(A1, A2, A3, A4, A5);
            this.заказыTableAdapter.Fill(this.заказыDataSet.Заказы);
        }

        private void button6_Click(object sender, EventArgs e)  // Изменение данных в таблице "Заказы"
        {
            string
                A1 = textBox6.Text, // Наименование
                A2 = textBox7.Text, // Цена
                A3 = textBox8.Text; // Город
            int
                A4 = Convert.ToInt32(textBox9.Text),    // Артикул
                A5 = Convert.ToInt32(textBox10.Text),   // КодЗ
                Code = Convert.ToInt32(textBox11.Text); // Код
            this.заказыTableAdapter.UpdateQuery(A1, A2, A3, A4, A5, Code);
            this.заказыTableAdapter.Fill(this.заказыDataSet.Заказы);
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e) // О программе
        {
            MessageBox.Show("Разработчк: Гришков Кирилл ИСП-32");

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)   // Сохранить
        {
            this.Validate();
            this.заказчикBindingSource.EndEdit();
            this.заказыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.заказыDataSet);
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e) // Закрыть
        {
            Application.Exit();
        }
    }
}
