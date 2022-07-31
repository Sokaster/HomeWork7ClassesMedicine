using System;
using System.Collections.Generic;
using System.Text;

namespace MedicineList
{
    internal class Vitamins:Pill
    {
        public Vitamins(string name, double cost, int amount, string colour, string typeofvitamin) : base(name, cost,amount,colour)
        {
            TypeOfVitamin = typeofvitamin;
        }
        public string TypeOfVitamin{ get; set; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Тип Витамина: {TypeOfVitamin}");
        }

        public override void HowToUse()
        {
            Console.WriteLine("Разжевать перед едой.");
        }
    }
}
