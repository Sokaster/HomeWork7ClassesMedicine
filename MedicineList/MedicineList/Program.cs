using System;
using MedicineList;

namespace MedicineList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MEDICINETEST:");
            Medicament medtest = new Medicament("medTest", 1.3);
            medtest.HowToUse();
            Console.WriteLine();

            Medicament[] medicamentArray = new Medicament[]
{
    new Pill("Крандиол", 20, 100,"Черный"),
    new Pill("Битомакс", 45, 20,"Красный"),
    new Cream("Увлажняющая Терапия", 16, 200,"Яркая летняя клубника с ароматом ванили"),
    new Cream("Освежающая Терапия", 20, 150,"Освежающее зеленое яблоко с оттенком Лайма"),
    new Cream("Успокаивающая Терапия", 18, 100,"Легкий миндальный аромат с кокосовым молоком"),
    new Ointment("Мазанол", 75, 235),
    new Ointment("Риколас", 35, 200),
    new Cyrup("Букварас", 35, 200,"Клубничный","Кашель"),
    new Cyrup("Холипопс", 25, 100,"Яблочный","Красное Горло"),
    new Vitamins("Цитрусин",15,100,"Апельсиновый","Витамин С"),
    new Vitamins("Буква А",15,100,"Кофейный","Витамин А")
};
            foreach (var medicine in medicamentArray)
            {
                medicine.Print();
                medicine.HowToUse();
                Console.WriteLine();
            }


            
        }
    }
}
