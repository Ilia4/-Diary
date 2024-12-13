using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class TaskItem
    {
        public string Title { get; set; }        // Название задачи
        public string Description { get; set; } // Описание задачи
        public DateTime DueDate { get; set; }   // Дедлайн
        public string Priority { get; set; }    // Приоритет (Напр.: Высокий, Средний, Низкий)
        public bool IsCompleted { get; set; }   // Статус выполнения
    }
}
