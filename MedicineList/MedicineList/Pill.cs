using System;
using System.Collections.Generic;
using System.Text;

namespace MedicineList
{
    internal class Pill:Medicament
    {
        private int _amount;
        public Pill(string name, double cost, int amount, string colour) : base(name, cost)
        {
            Amount = amount;
            Colour = colour;
        }
        public int Amount
        {
            get { return _amount; }
            set 
            {
                if (_amount < 0)
                {
                    _amount = 0;
                }
                else
                {
                    _amount = value;
                }
            }
        }
        public string Colour { get; set; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Количество таблеток в упаковке: {Amount}");
            Console.WriteLine($"Цвет таблеток: {Colour}");
        }

        public override void HowToUse()
        {
            Console.WriteLine("Принимать внутрь после еды. Не разжевывать. Запивать стаканом воды.");
        }

    }
}
