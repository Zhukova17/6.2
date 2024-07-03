using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace _6._2
{
    public partial class Form4 : Form
    {
        private List<string> items = new List<string>()
        {

            "Чай",
            "Кофе",
            "Сок",
            "Вода",
            "Омлет",
            "Блины",
            "Вафли",
            "Фрукты",
            "Салаты",
            "Супы",
            "Сэндвичи",
            "Паста",
            "Пицца",
            "Роллы",
            "Фри",
            "Бургер",
            "Закуски",
            "Торт",
            "Пирог",
            "Мороженое",

        };
        List<string> cart = new List<string>();
        private List<string> order = new List<string>();
        private List<string> orderedDishes = new List<string>();
        Random random = new Random();

        public Form4()
        {
            InitializeComponent();
            comboBox1.DataSource = items;
            //Timer timer = new Timer();
            //timer.Interval = 15000;
            //timer.Tick += Timer_Tick;
            //timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int randomEvent = random.Next(1, 4);

            switch (randomEvent)
            {
                case 1:
                    if (order.Count > 0)
                    {
                        MessageBox.Show("Произошла временная ошибка оплаты. Попробуйте снова позже.");
                    }
                    break;
                case 2:
                    MessageBox.Show("Поздравляем! Вы получили скидку 10% на ваш следующий заказ.");
                    break;
                case 3:
                    string randomItem = items[random.Next(items.Count)];
                    MessageBox.Show($"Хотите добавить {randomItem} в корзину?");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cart.Count > 0)
            {
                order.AddRange(cart);
                MessageBox.Show("Заказ оформлен. Товар добавлен в корзину.");
            }
            else
            {
                MessageBox.Show("Корзина пуста. Добавьте товары.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (order.Count > 0)
            {
                if (random.Next(1, 5) == 1)
                {
                    MessageBox.Show("Ошибка оплаты! Попробуйте позже.");
                }
                else
                {
                    MessageBox.Show("Заказ оплачен!");
                    order.Clear();
                    ClearCart();
                    Form2 form2 = new Form2();
                    form2.ReceiveOrder(orderedDishes);
                    form2.Show();
                }
            }
            else
            {
                MessageBox.Show("Заказ пуст.");
            }
        }

        private void UpdateCartDisplay()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = cart;
        }

        private void ClearCart()
        {
            cart.Clear();
            UpdateCartDisplay();
        }
    

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                cart.Add(comboBox1.SelectedItem.ToString());
                UpdateCartDisplay();
            }
            else
            {
                MessageBox.Show("Выберите товар из списка.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
