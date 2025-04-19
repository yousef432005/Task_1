using System;
using Task_1;

namespace CIS
{
    class Task_1
    {
        static void Main(string[] args)
        {

            Car car1 = new Car();
            car1.brand = "Fiat";
            car1.model = "128";
            car1.year = "1965";

            Console.WriteLine(car1.brand);
            Console.WriteLine(car1.model);
            Console.WriteLine(car1.year);

            Car car2 = new Car();
            car2.brand = "Mercedes";
            car2.model = "G-Class";
            car2.year = "2023";

            Console.WriteLine(car2.brand);
            Console.WriteLine(car2.model);
            Console.WriteLine(car2.year);
        }
    }
}