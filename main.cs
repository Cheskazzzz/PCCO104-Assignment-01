using System;

public class HelloWorld{
    public static void Main(string[] args) {

        decimal bills = 1000;

        switch (bills){
            case 0.01m:
                Console.WriteLine("No Person is Found");
                break;
            case 0.05m:
                Console.WriteLine("No Person is Found");
                break;
            case 0.25m:
                Console.WriteLine("No Person is Found");
                break;
            case 1:
                Console.WriteLine("Jose Rizal");
                break;
            case 5:
                Console.WriteLine("Emilio Aguinaldo");
                break;
            case 10:
                Console.WriteLine("Andres Bonifacio, Apolinario Mabini");
                break;
            case 20:
                Console.WriteLine("Manuel L. Quezon");
                break;
            case 50:
                Console.WriteLine("Sergio Osmena");
                break;
            case 100:
                Console.WriteLine("Manuel Roxas");
                break;
            case 200:
                Console.WriteLine("Diosdado Macapagal");
                break;
            case 500:
                Console.WriteLine("Benigno Sr. and Corazon Aquino");
                break;
            case 1000:
                Console.WriteLine("Jose Abad Santos, Vicent Lim, Josefa Llanes Escoda");
                break;
            default:
                Console.WriteLine("Invalid Denomination");
                break;
        }
    }
}