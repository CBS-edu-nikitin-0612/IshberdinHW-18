using System;

namespace Task2
{
    internal class Program
    {
        static void Main()
        {
            int count = 8;
            Train[] trains = new Train[count];
            Console.SetCursorPosition(0, count + 1);
            Console.WriteLine("Введите значения через пробел");
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("{0, -20} | {1,-20} | {2,-20}", "Пункт назначения", "Номер поезда", "Время отправления");
            for (int j = 0; j < trains.Length; j++)
            {
                trains[j] = new Train(Console.ReadLine().Split(' '));
                Console.SetCursorPosition(0, Console.GetCursorPosition().Top - 1);
                trains[j].GetInfo();
            }
            Console.WriteLine("Введите номер поезда для вывода информации");
            Console.SetCursorPosition(0, count + 3);
        }
    }
    struct Train
    {
        public string NameTo;
        public int Number;
        public DateTime TimeStart;

        public void GetInfo()
        {
            Console.WriteLine("{0, -20} | {1,-20} | {2,-20}", NameTo, Number, TimeStart);
        }
        public void GetInfo(int num)
        {
            Console.WriteLine("{0, -20} | {1,-20} | {2,-20}", NameTo, Number, TimeStart);
        }

        public Train(string[] inPut)
        {
            NameTo = inPut[0];
            Number = Convert.ToInt32(inPut[1]);
            TimeStart = Convert.ToDateTime(inPut[2]);
        }

    }
    static class Trains
    {
        public static void GetInfo(this Train[] trains, int number)
        {
            bool finded = false;
            foreach (Train train in trains)
            {
                if (train.Number == number)
                {
                    train.GetInfo();
                    finded = true;
                }
            }
            if (!finded)
            {
                Console.WriteLine($"Поездов с номером {number} нет");
            }
        }
    }
}

