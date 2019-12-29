using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    public class Order
    {
        public Order(string order, DateTime dateTime, int sum)
        {
            OrderText = order;
            Date = dateTime;
            Sum = sum;
        }
        public string OrderText { get; set; }
        public DateTime Date { get; set; }
        public int Sum { get; set; }
    }
}
