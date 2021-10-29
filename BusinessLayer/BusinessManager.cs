using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using Entities;

namespace BusinessLayer
{
    public class BusinessManager
    {
        public TaskItemRepository TaskItemRepo { get; set; }
        public BusinessManager()
        {
            TaskItemRepo = new TaskItemRepository();
        }

        public void LoadTasks()
        {
            TaskItemRepo.LoadTasks();
        }

        public List<TaskItem> GetTasks()
        {
            return TaskItemRepo.GetTasks();
        }

        public TaskItem FindTaskItem(string name)
        {
            return TaskItemRepo.FindTaskItem(name);
        }

        public void addTask(string name, string description, DateTime deadline)
        {
            TaskItemRepo.AddTask(name, description, deadline);
        }

        public List<TaskItem> tasksByDate()
        {
            List<TaskItem> taskItemsSorted = TaskItemRepo.tasksByDate();
            return taskItemsSorted;
        }

        public void RemoveTask(string name)
        {
            TaskItemRepo.RemoveTask(name);
        }

        public void SaveToFile()
        {
            TaskItemRepo.SaveToFile();
        }
    }
}
