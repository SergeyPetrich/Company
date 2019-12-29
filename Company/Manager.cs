using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    public class Manager : IEmployee
    {
        public Manager(string name, string jobResponsibilities)
        {
            Name = name;
            JobResponsibilities = jobResponsibilities;
        }
        public string Name { get; set; }
        public string JobResponsibilities { get; set; }
        public uint Salary { get; set; }

        public bool TakeTT(Order order)
        {
            Console.WriteLine("Менеджер " + Name + " принял ТЗ на исполнение.");
            return DoTT(order);
        }

        public bool DoTT(Order order)
        {
            Console.WriteLine("Менеджер " + Name + " выполнил задание.");
            return true;
        }

        public bool TakeClientProblem(string appeal)
        {
            return false;
        }
    }
}
