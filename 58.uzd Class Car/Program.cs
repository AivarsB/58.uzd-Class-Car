using System;
using System.Collections.Generic;
using System.Linq;

namespace _58.uzd_Class_Car
{
    class Program
    {
        static void Main(string[] args)
        {
            // Galvenajā programmā izveidojiet sarakstu ar 5 mašīnām. 

            var cars = new List<Car>
            {
                new Car()
                {
                    make = "Audi",
                    model = "A5",
                    price = 13000,
                    color = "Silver",
                    year = 2009
                },
                new Car()
                {
                    make = "BMW",
                    model = "320",
                    price = 8700,
                    color = "Black",
                    year = 2013
                },
                new Car()
                {
                    make = "Nissan",
                    model = "Qahqai",
                    price = 18000,
                    color = "Black",
                    year = 2015
                },
                new Car()
                {
                    make = "VAZ",
                    model = "2106",
                    price = 3000,
                    color = "Blue",
                    year = 1977
                },
                new Car()
                {
                    make = "Opel",
                    model = "Astra",
                    price = 5800,
                    color = "Grey",
                    year = 2005
                },
            };

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.AvailableCars()}");
            }

            // Atrodiet un izdrukājiet uz ekrāna dārgākās mašīnas informāciju. 

            var expensiveCar = cars.Max(x => x.price);

            foreach (var car in cars)
            {
                if (car.price == expensiveCar)
                {
                    Console.WriteLine($"Most expensive car is {car.AvailableCars()}");
                }
            }




        }
    }
}
// Izveidot klasi Car ar 5 property(īpašībām) Make, Model, Price un Color, Year, izvēlieties atbilstošus 
// datu tipus izveidotajiem laukiem. 
// Pievienojiet šai klases public metodi, kura atgriež visu informāciju par mašīnu kā tekstu, kur visas 
// vērtības ir atdalītas ar komatu. 
// Galvenajā programmā izveidojiet sarakstu ar 5 mašīnām. 
// Atrodiet un izdrukājiet uz ekrāna dārgākās mašīnas informāciju. 
// Dārgākās mašīnas atrašanai varat izmantot gan LINQ, gan parastu for vai foreach ciklu.
