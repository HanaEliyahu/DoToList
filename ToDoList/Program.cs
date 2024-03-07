using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Program
    {
        public static void Print(Task[] tasks)
        {
            Console.WriteLine("-------------------");
            int i = 0;
            while (tasks[i] != null)
            {
                tasks[i].print();
                i++;
            }
            Console.WriteLine("--------------------");
        }
        public static void AddTask(Task[] tasks)
        {
            int i = 0;
            while (tasks[i] != null)
                i++;
            Console.Write("Enter description, date and hour and status\ndescription: ");
            string str = Console.ReadLine();
            Console.Write("\ndate: ");
            DateTime d = DateTime.Parse(Console.ReadLine());
            Console.Write("\nstatus: ");
            bool s = bool.Parse(Console.ReadLine());
            tasks[i] = new Task(str, d, s);
        }
        public static void Update(Task[] tasks)
        {
            int i = 0, pressing;
            string str;
            Console.WriteLine("Which task would you like to update?");
            str = Console.ReadLine();
            while (tasks[i] != null)
            {
                if (tasks[i].Description == str)
                    break;
                i++;
            }
            Console.WriteLine("if you want to update the date press 1\nif you want to update the status press 2");
            pressing = int.Parse(Console.ReadLine());
            if (pressing == 1)
            {
                Console.WriteLine("Enter new date");
                tasks[i].updateDate(DateTime.Parse(Console.ReadLine()));
            }
            else
            {
                Console.WriteLine("Updade the status:");
                tasks[i].updateStatus(bool.Parse(Console.ReadLine()));
            }
        }
        public static void Delete(Task[] tasks)
        {
            int i = 0;
            string str;
            bool status = false;
            Console.WriteLine("Which task would you like to update?");
            str = Console.ReadLine();
            while (tasks[i] != null)
            {
                if (tasks[i].Description == str)
                    status = true;
                if (status)
                    tasks[i] = tasks[i + 1];
                i++;
            }
        }
        static void Main(string[] args)
        {
            Task[] tasks = new Task[100];
            tasks[0] = new Task("to go to...", new DateTime(2024, 06, 03, 10, 10, 09), false);
            tasks[1] = new Task("to do", new DateTime(2024, 07, 03, 11, 12, 15), false);
            int pressing = 0;
            while (pressing != -1)
            {
                Print(tasks);
                Console.WriteLine("press 1 to add a task, 2 to update and 3 to delete a task");
                pressing = int.Parse(Console.ReadLine());
                switch (pressing)
                {
                    case 1:
                        AddTask(tasks);
                        break;
                    case 2:
                        Update(tasks);
                        break;
                    case 3:
                        Delete(tasks);
                        break;

                }
            }
            Print(tasks);
            Console.ReadKey();
        }
    }
        }
