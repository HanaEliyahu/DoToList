using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Task
    {
        private string description;
        private DateTime date;
        private bool status;
        public Task()
        {

        }
        public Task(string description, DateTime date, bool status)
        {
            this.description = description;
            this.date = date;
            this.status = status;
        }
        public void updateDate(DateTime date)
        {
            this.date = date;
        }
        public void updateStatus(bool status)
        {
            this.status = status;
        }
        public void print()
        {
            Console.WriteLine("description: " + this.description + "\ndate: " + this.date + "\nstatus: " + this.status + "\n");
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }



    }
}
