using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _6._2
{
    public partial class Form2 : Form
    {
        private List<string> dishes = new List<string>();
        Random random = new Random();
        public Form2()
        {
            InitializeComponent();
        }
        public void ReceiveOrder(List<string> orderedDishes)
        {
            dishes = orderedDishes;
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            listBox1.Items.Clear();
            foreach (string dish in dishes)
            {
                listBox1.Items.Add(dish);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int randomDishIndex = random.Next(dishes.Count);

            if (random.Next(1, 11) <= 1) 
            {
                MessageBox.Show($"К сожалению, блюдо '{dishes[randomDishIndex]}' временно недоступно.");
                dishes.RemoveAt(randomDishIndex);
                UpdateListBox();
            }
            else
            {
                int preparationTime = random.Next(5, 15);
                MessageBox.Show($"Заказ готовится. Ожидайте {preparationTime} секунд.");
                System.Threading.Thread.Sleep(preparationTime * 1000);
                MessageBox.Show("Заказ готов!");
                dishes.Clear();
                UpdateListBox();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }
    }
}
