using System;

namespace UnitConverter
{
    public class Program
    {
        static void Main(string[] args)
        {
            double unit_type;
            double unit;
            double value1;
            double value2;

            Console.WriteLine("To convert units of mass, type 1");
            Console.WriteLine("To convert units of length, type 2");

            unit_type = Convert.ToDouble(Console.ReadLine());

            if (unit_type == 1)
            {
                Console.WriteLine("Pounds to Ounces (type 1)");
                Console.WriteLine("Pounds to Tons (type 2)");
                Console.WriteLine("Ounces to Pounds (type 3)");
                Console.WriteLine("Ounces to Tons (type 4)");
                Console.WriteLine("Tons to Ounces (type 5)");
                Console.WriteLine("Tons to Pounds (type 6)");
                
                unit = Convert.ToDouble(Console.ReadLine());

                if (unit == 1)
                {
                    Console.WriteLine("How many pounds?");
                    value1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    value2 = value1 * 16;
                    Console.WriteLine($"{value1} pounds = {value2} ounces");
                }
                
                if (unit == 2)
                {
                    Console.WriteLine("How many pounds?");
                    value1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    value2 = value1 / 2000;
                    Console.WriteLine($"{value1} pounds = {value2} tons");
                }

                if (unit == 3)
                {
                    Console.WriteLine("How many ounces?");
                    value1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    value2 = value1 / 16;
                    Console.WriteLine($"{value1} ounces = {value2} pounds");
                }

                if (unit == 4)
                {
                    Console.WriteLine("How many ounces?");
                    value1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    value2 = value1 / 32000;
                    Console.WriteLine($"{value1} ounces = {value2} tons");
                }

                if (unit == 5)
                {
                    Console.WriteLine("How many tons?");
                    value1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    value2 = value1 * 32000;
                    Console.WriteLine($"{value1} tons = {value2} ounces");
                }

                if (unit == 6)
                {
                    Console.WriteLine("How many tons?");
                    value1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    value2 = value1 * 2000;
                    Console.WriteLine($"{value1} tons = {value2} pounds");
                }
            }
        }
    }
}