using System;
using System.Collections.Generic;
using System.Text;

namespace MedicineList
{
    internal class Cream:Ointment
    {
        public Cream(string name,double cost,double volume,string smell):base(name,cost,volume) 
        {
            Smell = smell;
        }

        public string Smell { get; set; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Запах крема: {Smell} ");
        }

        public override void HowToUse()
        {
            Console.WriteLine($"Небольшое количество втирать массажными движения.");
        }
    }
}
