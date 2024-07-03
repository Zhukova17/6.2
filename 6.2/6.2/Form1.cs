using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _6._2
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int tableNumber = int.Parse(textBox1.Text);

                if (tableNumber >= 1 && tableNumber <= 10)
                {
                    if (random.Next(2) == 0)
                    {
                        Console.WriteLine($"Выбран стол {tableNumber}");
                        MessageBox.Show($"Стол {tableNumber} свободен.");
                    }
                    else
                    {
                        MessageBox.Show($"К сожалению, стол {tableNumber} занят.");
                    }
                }
                else
                {
                    MessageBox.Show("Неверно введен номер стола, пожалуйста, введите число от 1 до 10");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода: введите целое число");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла нештатная ситуация: " + ex.Message);
            }
        }

        private void контрольРаботыЗалаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void контрольРаботыСПерсоналомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }
    }
}
