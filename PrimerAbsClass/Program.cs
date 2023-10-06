using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PrimerAbsClass
{
    abstract class InformationPet
    {
        public abstract void Information();

    }
    class Owner : InformationPet
    {
        public string Last_Name { get; set; } //Фамилия
        public string Name { get; set; } //Имя
        public string Patronymic { get; set; } //Отчество

        public override void Information()
        {
            Console.WriteLine($"ФИО владельца: {Last_Name} {Name} {Patronymic}");
        }
    }
    class Pet : InformationPet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Pol { get; set; }
        public string Vid_Okr { get; set; }
        public double Ves { get; set; }
        public override void Information()
        {
            Console.WriteLine($"Кличка питомца: {Name}.\n" +
                $"Возраст питомца/ пол: {Age} , {Pol}.\n" +
                $"Вид/порода {Vid_Okr}. \n" +
                $"Вес: {Ves}.");
        }
    }

    class Date_Pos : InformationPet
    {
        public DateTime Date_poses { get; set; }
        public override void Information()
        {
            Console.WriteLine($"Дата помещения: {Date_poses}");
        }

        class Kartochka
        {
            public void Information(InformationPet informationPet)
            {
                informationPet.Information();
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Owner owner = new Owner { Last_Name = "Корнилова", Name = "Варвара", Patronymic = "Дмитриевна" };
                Pet pet = new Pet { Name = "Чипс", Age = 1, Pol = "М", Vid_Okr = "Кошка/ метис", Ves = 4.6 };
                Date_Pos date_Pos = new Date_Pos { Date_poses = new DateTime(2023, 09, 22, 10, 45, 00) };


                owner.Information();
                pet.Information();


                Kartochka kartochka = new Kartochka();
                kartochka.Information(date_Pos);
                Console.ReadKey();
            }
        }
    }
}
