using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the denomination of the Philippine Bank Note (Bills and Coins): ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double denomination))
        {
            string personality = GetPersonality(denomination);
            if (personality != "No Person is found")
            {
                Console.WriteLine($"Personality found in {denomination}: {personality}");
            }
            else
            {
                Console.WriteLine($"No Person is found for denomination {denomination}");
            }
        }
        else
        {
            Console.WriteLine($"Invalid Input: '{input}' is not a valid number.");
        }
    }

    static string GetPersonality(double denomination)
    {
        string personality = "No Person is found";

        if (denomination == 0.01 || denomination == 0.05 || denomination == 0.25)
        {
            return personality; 
        }

        if (denomination % 1 == 0) 
        {
            switch (denomination)
            {
                case 1:
                    personality = "Jose Rizal";
                    break;
                case 5:
                    personality = "Emilio Aguinaldo";
                    break;
                case 10:
                    personality = "Andres Bonifacio, Apolinario Mabini";
                    break;
                case 20:
                    personality = "Manuel L. Quezon";
                    break;
                case 50:
                    personality = "Sergio Osmena";
                    break;
                case 100:
                    personality = "Manuel Roxas";
                    break;
                case 200:
                    personality = "Diosdado Macapagal";
                    break;
                case 500:
                    personality = "Benigno Sr. and Corazon Aquino";
                    break;
                case 1000:
                    personality = "Jose Abad Santos, Vincent Lim, Josefa Llanes Escoda";
                    break;
                default:
                    personality = "Invalid Denomination"; 
                    break;
            }
        }
        else
        {
            personality = "Invalid Denomination";
        }

        return personality;
    }
}
