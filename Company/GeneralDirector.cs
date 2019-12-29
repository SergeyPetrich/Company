using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    public class GeneralDirector : IEmployee
    {
        public GeneralDirector(string name, string jobResponsibilities)
        {
            Name = name;
            JobResponsibilities = jobResponsibilities;
        }
        public string Name { get; set; }
        public string JobResponsibilities { get; set; }
        public uint Salary { get; set; }

        public bool Singing(Order order)
        {
            Console.WriteLine("Генеральный директор " + Name + " подписал заказ " + order.OrderText);
            return true;
        }
    }
}
