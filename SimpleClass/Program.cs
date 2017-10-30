using System;

namespace SimpleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car
            {
                Make = "Honada",
                Model = "Civic",
                Color = "Black",
                Year = 2005
            };

            Car.DetermineNothing();

            Console.WriteLine(
                "My Car is a {3} {2} {0} {1}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            decimal value = myCar.DetermineMarketValue();
            Console.WriteLine("Valued at: {0:C} ", value);
            Console.ReadLine();

        }


    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal DetermineMarketValue()
        {
            decimal carValue;
            if (Year > 2010)
                carValue = (decimal)(Year * .75);
            else
                carValue = (decimal)(Year * 0.5);
            return carValue;
        }

        public static void DetermineNothing()
        {
            Console.WriteLine("Calling a class Method");
        }
    }

}
