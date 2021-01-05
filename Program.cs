using System;

namespace Modulo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool close = false;
            Console.WriteLine("Podaj liczbę a sprawdzę czy jest parzysta czy nieparzysta:  Jeśli chcesz zakończyć naciśnij Z");

            while (close == false)
            {

                string userInput = Console.ReadLine();

                if (userInput == "Z" || userInput == "z")
                    close = true;

                else if (!(int.TryParse(userInput, out int number)))
                {
                    Console.WriteLine("Wprowadzono złe dane spróbuj ponownie");
                }
                else if (number % 2 == 0)
                {
                    Console.WriteLine("Liczba jest parzysta");
                }
                else
                {
                    Console.WriteLine("Liczba jest nieparzysta");
                }

            }

        }
    }
}
