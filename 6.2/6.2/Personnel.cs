using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2
{
    public class Personnel
    {
        private string[] personnelStatuses = new string[] {
            "Все в порядке",
            "Недостаточно персонала",
            "Перерыв",
            "Занято"
        };

        private string[] personnelEvents = new string[] {
            "Сотрудник ушел на обед",
            "Поступил новый заказ",
            "Сотрудник готов к работе",
            "Сотрудник переведен на другой участок",
            "Проблема с кассовым аппаратом"
        };

        private Random random = new Random();

        public string Status { get; private set; }
        public string Event { get; private set; }

        public Personnel()
        {
            GenerateRandomStatus();
            GenerateRandomEvent();
        }

        private void GenerateRandomStatus()
        {
            Status = personnelStatuses[random.Next(personnelStatuses.Length)];
        }

        private void GenerateRandomEvent()
        {
            Event = personnelEvents[random.Next(personnelEvents.Length)];
        }
    }
}
