using System;
using System.Collections.Generic;
using System.Text;

namespace MedicineList
{
    internal class Cyrup:Cream
    {
        public Cyrup(string name, double cost, double volume, string smell,string typefor):base(name,cost,volume,smell)
        {
            TypeFor = typefor; 
        }
        public string TypeFor { get; set; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Применять при следующих симптомах: {TypeFor}");
        }

        public override void HowToUse()
        {
            Console.WriteLine($"1 ст. ложка 3 раза в день перед едой взрослым. Старше 18 лет.");
        }
    }
}
