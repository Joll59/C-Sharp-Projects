using System;
using System.Collections;
using System.Collections.Generic;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car
            {
                Make = "Honda",
                Model = "Civic",
                VIN = "L9"
            };
            Car car2 = new Car
            {
                Make = "Geo",
                Model = "Prism",
                VIN = "T9"

            };
            Book b1 = new Book
            {
                Author = "Minori Miyata",
                Title = "Dealing with a Wasp",
                ISBN = "0-000-00017-9"
            };
            // ArrayList
            /* typically you call myArrayList.add(`itemToAdd`) 
             *   shortened using object initiaze. */
            //ArrayList myArrayList = new ArrayList
            //{
            //    car1,
            //    car2
            //};
            //foreach (Car car in myArrayList)
            //{
            //    Console.WriteLine(car.Model);
            //}

            //List<T>

            //List<Car> myCars = new List<Car>
            //{
            //    car1,
            //    car2
            //};

            //List<Book> myBooks = new List<Book>();
            //myBooks.Add(b1);

            //foreach (Car car in myCars)
            //{
            //    Console.WriteLine(car.Model);
            //}

            //foreach (Book book in myBooks)
            //{
            //    Console.WriteLine(book.ISBN);
            //}

            //Dictionary<TKey, TValue>
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();

            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.ReadLine();
        }
    }

    class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
    }
    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        //public Car(string make, string model)
        //{
        //    Make = make;
        //    Model = model;
        //}
    }
}
