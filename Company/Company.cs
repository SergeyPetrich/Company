using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Company
{
    public class Company
    {
        public Company(string name, int inn, ExecutiveDirector executiveDirector, GeneralDirector generalDirector)
        {
            Name = name;
            INN = inn;
            ExecutiveDirector = executiveDirector;
            GeneralDirector = generalDirector;
            TechnicalSupport = new TechnicalSupport();
            TechnicalSupport.TechnicalManager = new Manager("Бедная Настя", " ");
        }
        private string Name { set; get; }
        private int INN { set; get; }
        public ExecutiveDirector ExecutiveDirector { set; get; }
        public GeneralDirector GeneralDirector { set; get; }
        public ICollection<Client> Clients = new List<Client>();

        public TechnicalSupport TechnicalSupport;

        private int money = 0;

        private ICollection<Order> Orders { get; set; } = new List<Order>();

        public bool Signing(string order)
        {
            return true;
        }
        public bool Processing(Order order)
        {
            ExecutiveDirector.GetOrder(order);
            return true;   
        }
        public void GetOrder(Client client, string order)
        {
            if(!Clients.Contains(client)) Clients.Add(client);
            Order o = new Order(order, DateTime.Now, 1000);
            Orders.Add(o);
            if (Processing(o))
            {
                GeneralDirector.Singing(o);
            }
            client.PayForOrder(this, o.Sum);
        }

        public string GiveCheck(Client client, int sum)
        {
            money += sum;
            return "Success";
        }

        public string GetAppeal(string appeal)
        {
            return TechnicalSupport.Proccessing(appeal);
        }
    }
}
