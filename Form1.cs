using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_на_for
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Задача на for";  // заголовок формы
            textBox1.Text = Properties.Settings.Default.chisla.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // кнопка "определить"
        {

            string chisla = Convert.ToString(this.textBox1.Text);
            MessageBox.Show(Logic.MainLogic(chisla));
            Properties.Settings.Default.chisla = chisla;
            Properties.Settings.Default.Save();  // автосохранение



        }

        private void clear_Click(object sender, EventArgs e) // кнпока "очистить"
        {
            textBox1.Text = "";

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) // защита данных
        {

            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    public class Logic
    {
        public static string MainLogic(string chisla)

        {
            string OutMessage;         // переменная для сообщения
            int min = Convert.ToInt32(chisla[1]); // преобразование в битовое экв. число
            int max = 0;             // вводим числа и позиции
            int min_pos = 0;
            int max_pos = 0;

            for (int i = 1; i < chisla.Length; i++)
            {
                if (Convert.ToInt32(chisla[i]) < min)
                {
                    min = Convert.ToInt32(chisla[i]);
                    min_pos = i;
                }
                if (Convert.ToInt32(chisla[i]) > max)
                {
                    max = Convert.ToInt32(chisla[i]);
                    max_pos = i;
                }
            }
            if (max_pos < min_pos)
                return OutMessage = "Максимальное число "+ chisla[0] + " левее!"; // собственно тут была ошибка с выводом, которую вы записали в блокнот, я её починил
            else
                return OutMessage = "Минимальное число " + chisla[0] + " левее!"; // ну и тут :)
        }
    }

}
