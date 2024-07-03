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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            // Инициализация элементов управления
            labelStatus = new Label();
            labelEvent = new Label();
            buttonRefresh = new Button();
            timerUpdate = new Timer();

            // Настройка элементов управления
            labelStatus.Location = new Point(50, 50);
            labelStatus.Text = "Все в порядке";
            labelEvent.Location = new Point(50, 80);
            labelEvent.Text = "Нет событий";
            buttonRefresh.Location = new Point(50, 110);
            buttonRefresh.Text = "Обновить";
            buttonRefresh.Click += ButtonRefresh_Click;
            timerUpdate.Interval = 5000; // 5 секунд
            timerUpdate.Tick += TimerUpdate_Tick;
            timerUpdate.Start();

            // Добавление элементов управления на форму
            this.Controls.Add(labelStatus);
            this.Controls.Add(labelEvent);
            this.Controls.Add(buttonRefresh);

            // Инициализация фасадного класса
            personnelService = new PersonnelServiceFacade();

            // Инициализация начальных значений
            UpdatePersonnelInfo();
        }
        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            UpdatePersonnelInfo();
        }

        private void TimerUpdate_Tick(object sender, EventArgs e)
        {
            UpdatePersonnelInfo();
        }

        private void UpdatePersonnelInfo()
        {
            labelStatus.Text = personnelService.GetPersonnelStatus();
            labelEvent.Text = personnelService.GetPersonnelEvent();
        }
    }

    // Интерфейс для работы с персоналом
    public interface IPersonnelService
    {
        string GetPersonnelStatus();
        string GetPersonnelEvent();
    }

    // Фасадный класс
    public class PersonnelServiceFacade : IPersonnelService
    {
        private Personnel personnel;

        public PersonnelServiceFacade()
        {
            personnel = new Personnel();
        }

        public string GetPersonnelStatus()
        {
            return personnel.Status;
        }

        public string GetPersonnelEvent()
        {
            return personnel.Event;
        }
    }
}
