using System;
using System.Collections.Generic;
using System.Text;

namespace MedicineList
{
    internal class Medicament
    {
        private double _cost;

        public Medicament(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }

       
        public double Cost
        {
            get { return _cost; }
            set
            {
                if (_cost < 0)
                {
                    _cost = 0;
                }
                else
                {
                    _cost = value;
                }
            }
        }

        public string Name { get; set; }

        public virtual void Print()
        {
            Console.WriteLine($"Название препарата: {Name}");
            Console.WriteLine($"Цена: {Cost} dollars");
        }

        public virtual void HowToUse()
        {
            Console.WriteLine($"Принимать внутрь либо внутревенно через капельницу");
        }

    }
}
