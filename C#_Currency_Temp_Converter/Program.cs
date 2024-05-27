//Following this tutorial => https://youtu.be/CigGiIb7HeM?si=BfAMw9x91ojlxioV

namespace C__Currency_Temp_Converter
{
    //Remove internal from the class name
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Currency and Temperature Converter!");
            Console.WriteLine("Please enter...\n\nc) Currency Converter\nanything else) Temperature Converter");
            string answer = Console.ReadLine();

            if (answer == "c")
            {
                Console.Clear();
                Console.WriteLine(" -- Currency Converter -- ");
                Console.WriteLine("Please enter...\n\na) Convert Pounds\nanything else) Convert Euros\n\n");
                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    Console.Clear();
                    Console.Write("Please enter your amount in British Pounds: ");
                    float pounds = float.Parse(Console.ReadLine());
                    float euros = pounds * 1.16f;
                    Console.WriteLine($"{pounds} British Pounds converted to Euros is {euros.ToString("0.00")}");
                }
                else
                {
                    Console.Clear();
                    Console.Write("Please enter your amount in Euros: ");
                    float euros = float.Parse(Console.ReadLine());
                    float pounds = euros / 1.16f;
                    Console.WriteLine($"{euros} Euros converted to British Pounds is {pounds.ToString("0.00")}");

                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine(" -- Temperature Converter -- ");
                Console.WriteLine("Please enter..\n\nc) Celsius\nanything else) Fahrenheit\n");
                string choice = Console.ReadLine();

                if (choice == "c")
                {
                    Console.Clear();
                    Console.Write("Enter a temperature in Celsius: °");
                    float celsius = float.Parse(Console.ReadLine());
                    float fahrenheit = celsius * 1.18f + 32f;
                    Console.WriteLine($"{celsius}°C converted to Fahrenheit is {fahrenheit.ToString("0.0")}°F");//Num Lock ON -> Alt + 0176 -> release Alt = How to make (°) symbol
                }
                else
                {
                    Console.Clear();
                    Console.Write("Please enter a temperature in Fahrenheit: °");
                    float fahrenheit = float.Parse(Console.ReadLine());
                    float celsius = (fahrenheit - 32f) / 1.18f;
                    Console.WriteLine($"{fahrenheit}°F converted to Celsius is {celsius.ToString("0.0")}°C");
                }
            }
        }
    }
}
