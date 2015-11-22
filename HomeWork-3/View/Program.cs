using System;
using Model;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            Gambler jay=new Jay();
            Gambler silentBob = new SilentBob();
            Random rnd = new Random();
            Numbertron numbertron= new Numbertron();

            numbertron.NewNumber += jay.FetchNewNumber;
            numbertron.NewNumber += silentBob.FetchNewNumber;

            var number=0;
            while (number<=0)
            {
                Console.WriteLine("Количество чисел для решения спора: ");
                int.TryParse(Console.ReadLine(), out number);
            }
            for (var n = 0; n <= number; n++)
            {
                numbertron.Generate(rnd);
            }

            if (jay.Score > silentBob.Score)
            {
                Console.WriteLine("Jay Win");
            }
            if (silentBob.Score > jay.Score)
            {
                Console.WriteLine("SilentBob Win");
            }
            if (jay.Score == silentBob.Score)
            {
                Console.WriteLine("Draw");
            }
            Console.ReadKey();
        }
    }
}
