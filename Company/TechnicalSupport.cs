using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    public class TechnicalSupport
    {
        public List<string> Task { get; set; } = new List<string>();
        public Manager TechnicalManager { set; get; }
        public string Proccessing(string appeal)
        {
            Task.Add(appeal);
            TechnicalManager.TakeClientProblem(appeal);
            return "Ваше обращение \"" + appeal + "\" принято к обработке! Постараемся вам помочь!";
        }
    }
}
