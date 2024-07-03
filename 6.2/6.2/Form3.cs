using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._2
{
    public partial class Form3 : Form
    {
        private Random random = new Random();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int situation = random.Next(5);
            switch (situation)
            {
                case 0:
                    MessageBox.Show("К сожалению, фуд-корт сейчас на техническом обслуживании. Попробуйте зайти позже.");
                    break;
                case 1:
                    MessageBox.Show("В фуд-корте возникла небольшая очередь. Пожалуйста, наберитесь терпения.");
                    break;
                case 2:
                    MessageBox.Show("В фуд-корте произошла небольшая задержка с приготовлением блюд. Приносим извинения за неудобства.");
                    break;
                case 3:
                    MessageBox.Show("В фуд-корте закончились некоторые продукты. Мы работаем над их пополнением.");
                    break;
                case 4:
                    DialogResult result = MessageBox.Show("В фуд-корте проходит акция - скидка на все напитки! Хотите узнать больше?", "Акция!", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Form4 f4 = new Form4();
                        f4.ShowDialog();
                    }
                    else
                    {
                       
                    }
                    break;
            }
        }
    }
}
