using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.IO;

namespace DataLayer
{
    public class DataManager
    {
        public void SaveToFile(List<TaskItem> tasks)
        {
            StreamWriter sw = new StreamWriter("ToDo.txt");

            foreach (TaskItem t in tasks)
            {
                sw.WriteLine(t.Name + "\t" + t.Description + "\t" + t.Deadline.ToString());
            }

            sw.Close();
        }

        public List<TaskItem> ReadFile()
        {
            StreamReader sr = new StreamReader("ToDo.txt");
            string row;

            List<TaskItem> tasks = new List<TaskItem>();

            while ((row = sr.ReadLine()) != null)
            {
                string[] splitRow = row.Split('\t');
                TaskItem t = new TaskItem();
                t.Name = splitRow[0];
                t.Description = splitRow[1];
                t.Deadline = DateTime.Parse(splitRow[2]);

                tasks.Add(t);
            }

            sr.Close();

            return tasks;
        }
    }
}
