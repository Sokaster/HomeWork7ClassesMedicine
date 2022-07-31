using System;
using System.Collections.Generic;
using System.Text;

namespace MedicineList
{
    internal class Ointment:Medicament
    {
        private double _volume;
        public Ointment(string name, double cost, double volume):base(name,cost)
        {
            Volume = volume;
        }

        

        public double Volume
        {
            get { return _volume; }
            set
            {
                if (_volume < 0)
                {
                    _volume = 0;
                }
                else 
                {
                    _volume = value;
                }
            }
        }

        public override void Print()
        {
            base.Print();
            
            Console.WriteLine($"Обьём Мази:{Volume} мл.");
        }

        public override void HowToUse()
        {
            Console.WriteLine($"Втирать тонким слоем до ощущения прохлады в месте поражения.");
        }
    }
}
