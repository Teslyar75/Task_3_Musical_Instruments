/*Завдання 3
Створити базовий клас «Музичний інструмент» і похідні
класи: «Скрипка», «Тромбон», «Укулеле», «Віолончель». За
допомогою конструктора, встановити назву до кожного
музичного інструменту і його характеристики.
Реалізуйте для кожного з класів методи:
■ Sound — видає звук музичного інструменту (пишемо
текстом у консоль);
■ Show — відображає назву музичного інструменту;
■ Desc — відображає опис музичного інструменту;
■ History — відображає історію створення музичного
інструменту.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Musical_Instruments
{
    class MusicalInstrument
    {
        private string name;
        private string description;

        public MusicalInstrument(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Звук музыкального инструмента.");
        }

        public void Show()
        {
            Console.WriteLine($"Название инструмента: {name}");
        }

        public void Desc()
        {
            Console.WriteLine($"Описание инструмента: {description}");
        }

        public virtual void History()
        {
            Console.WriteLine("История создания музыкальных инструментов.");
        }
    }

    class Violin : MusicalInstrument
    {
        public Violin(string name, string description) : base(name, description)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Звук скрипки");
        }

        public override void History()
        {
            Console.WriteLine("Скрипка впервые упоминается с 16-го века.");
        }
    }

    class Trombone : MusicalInstrument
    {
        public Trombone(string name, string description) : base(name, description)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Звук тромбона");
        }

        public override void History()
        {
            Console.WriteLine("Тромбон появился в 15 веке");
        }
    }

    class Ukulele : MusicalInstrument
    {
        public Ukulele(string name, string description) : base(name, description)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Звук укулеле");
        }

        public override void History()
        {
            Console.WriteLine("История создания укулеле.");
        }
    }

    class Cello : MusicalInstrument
    {
        public Cello(string name, string description) : base(name, description)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Звук виолончели");
        }

        public override void History()
        {
            Console.WriteLine("Виолончель развивалась до 17 века");
        }
    }

    class Program
    {
        static void Main()
        {
            MusicalInstrument violin = new Violin("Скрипка", "Смычковый инструмент маленького размера.");
            MusicalInstrument trombone = new Trombone("Тромбон", "Духовой инструмент.");
            MusicalInstrument ukulele = new Ukulele("Укулеле", "Струнный инструмент маленького размера");
            MusicalInstrument cello = new Cello("Виолончель", "Смычковый инструмент большого размера");

            violin.Show();
            violin.Sound();
            violin.Desc();
            violin.History();
            Console.WriteLine();
            trombone.Show();
            trombone.Sound();
            trombone.Desc();
            trombone.History();
            Console.WriteLine();
            ukulele.Show();
            ukulele.Sound();
            ukulele.Desc();
            ukulele.History();
            Console.WriteLine();
            cello.Show();
            cello.Sound();
            cello.Desc();
            cello.History();
            Console.ReadKey();
        }
    }

}
