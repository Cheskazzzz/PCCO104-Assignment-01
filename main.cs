using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the denomination of the Philippine Bank Note (Bills and Coins): ");
        double denomination;
        if (double.TryParse(Console.ReadLine(), out denomination))
        {
            string personality = GetPersonality(denomination);
            Console.WriteLine($"Personality found in {denomination}: {personality}");
        }
        else
        {
            Console.WriteLine($"Invalid Denomination: {Console.ReadLine()}");
        }
    }
    static string GetPersonality(double denomination)
    {
        string personality = "No Person is found";
        if (denomination == 1)
        {
            personality = "Jose Rizal";
        }
        else if (denomination == 5)
        {
            personality = "Emilio Aguinaldo";
        }
        else if (denomination == 10)
        {
            personality = "Andres Bonifacio, Apolinario Mabini";
        }
        else if (denomination == 20)
        {
            personality = "Manuel L. Quezon";
        }
        else if (denomination == 50)
        {
            personality = "Sergio Osmena";
        }
        else if (denomination == 100)
        {
            personality = "Manuel Roxas";
        }
        else if (denomination == 200)
        {
            personality = "Diosdado Macapagal";
        }
        else if (denomination == 500)
        {
            personality = "Benigno Sr. and Corazon Aquino";
        }
        else if (denomination == 1000)
        {
            personality = "Jose Abad Santos, Vincent Lim, Josefa Llanes Escoda";
        }

        return personality;
    }
  }