using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lesson_07_PoP.Enums;

namespace Lesson_07_PoP
{
    public class Program
    {
        private static Catalogue<Car> cars = new Catalogue<Car>();

        private static Catalogue<Plane> planes = new Catalogue<Plane>();

        private static void Main(string[] args)
        {
            cars.Add(new Car { Make = Make.Ford, Model = Model.Escape, Color = Color.Blue, Year = 2020, RegistrationNumber = "5" });
            cars.Add(new Car { Make = Make.Ford, Model = Model.Focus, Color = Color.Blue, Year = 2021, RegistrationNumber = "4" });
            cars.Add(new Car { Make = Make.Renault, Model = Model.Megane, Color = Color.Blue, Year = 2022, RegistrationNumber = "3" });
            cars.Add(new Car { Make = Make.Toyota, Model = Model.Corolla, Color = Color.Blue, Year = 2023, RegistrationNumber = "2" });
            cars.Add(new Car { Make = Make.Toyota, Model = Model.Camry, Color = Color.Blue, Year = 2024, RegistrationNumber = "1" });

            planes.Add(new Plane { Year = 2020, RegistrationNumber = "123", NumberOfWings = 2 });
            planes.Add(new Plane { Year = 2020, RegistrationNumber = "aaa", NumberOfWings = 2 });

            while (true)
            {
                DisplayMenu();
                string choice = Console.ReadLine();

                if (choice == "6")
                {
                    break;
                }
                else
                {
                    switch (choice)
                    {
                        case "1":
                            AddNewCar();
                            Console.ReadKey();
                            break;

                        case "2":
                            RemoveCar();
                            break;

                        case "3":
                            ListAllCars("year");
                            break;

                        case "4":
                            ListAllCars("regNumber");
                            break;

                        case "5":
                            Search();
                            break;
                    }
                }
            }
        }

        private static void Search()
        {
            Console.Clear();
            Console.Write("Please enter a year of car to search: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int year))
            {
                var car = cars.SearchByYear(year);
                if (car != null)
                {
                    Console.WriteLine("------------------------------------------");

                    Console.Write("Car found: ");
                    Console.WriteLine(car.ToString());

                    Console.WriteLine("------------------------------------------");
                }
                else
                {
                    Console.WriteLine($"There is no car from year {year} in the list. ");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }

            EnterToContinue();
        }

        private static void ListAllCars(string orderByField)
        {
            Console.Clear();

            cars.SortBy(orderByField);
            cars.List();

            EnterToContinue();
        }

        private static void EnterToContinue()
        {
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();
        }

        private static void RemoveCar()
        {
            Console.Clear();
            Console.Write("Please enter an index of car to remove: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int i))
            {
                if (cars.Remove(i))
                {
                    Console.WriteLine("Car was removed from the list");
                }
                else
                {
                    Console.WriteLine("Car was NOT removed from the list");
                }
            }
            else
            {
                Console.WriteLine("Please enter a number for the index.");
            }

            EnterToContinue();
        }

        private static void AddNewCar()
        {
            Console.WriteLine("Not implemented, please try again later...");
        }

        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("=========================");
            Console.WriteLine("1. Add new car");
            Console.WriteLine("2. Remove car");
            Console.WriteLine("3. List all cars - ordered by year");
            Console.WriteLine("4. List all cars - ordered by reg.number");
            Console.WriteLine("5. Search for car");
            Console.WriteLine("6. Exit");
            Console.WriteLine("=========================");
            Console.Write("Please enter your choice (1-5) ");
        }
    }
}
