using System;
using System.Collections.Generic;

namespace ProgrammingCSharpGenericsChallenge
{
    public class ClassicCar
    {
        public string m_Make;
        public string m_Model;
        public int m_Year;
        public int m_Value;

        public ClassicCar(string make, string model, int year, int val)
        {
            m_Make = make;
            m_Model = model;
            m_Year = year;
            m_Value = val;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<ClassicCar> carList = new List<ClassicCar>();
            populateData(carList);

            // How many cars are in the collection?
            Console.WriteLine("There are {0} cars in the entire collection\n", carList.Count);

            // How many Fords are there?
            int FordCount = carList.FindAll(x => x.m_Make == "Ford").Count;
            Console.WriteLine("There are {0} Fords in the entire collection\n", FordCount);

            // What is the most valuable car?
            ClassicCar mostValuableCar = carList[0];
            foreach (var car in carList)
            {
                if(car.m_Value > mostValuableCar.m_Value)
                {
                    mostValuableCar = car;
                }
            }
            Console.WriteLine("The most valuable car is a {0} {1} {2} at ${3}\n", mostValuableCar.m_Year, mostValuableCar.m_Make, mostValuableCar.m_Model, mostValuableCar.m_Value);

            // What is the entire collection worth?
            int totalValue = 0;
            carList.ForEach(x => totalValue += x.m_Value);
            Console.WriteLine("The collection is worth ${0}\n", totalValue);

            // How many unique manufacturers are there?
            HashSet<string> carSet = new HashSet<string>();
            carList.ForEach(x => carSet.Add(x.m_Make));
            Console.WriteLine("The collection contains {0} unique manufacturers", carSet.Count);


            Console.WriteLine("\nHit Enter key to continue...");
            Console.ReadLine();
        }

        static void populateData(List<ClassicCar> theList)
        {
            theList.Add(new ClassicCar("Alfa Romeo", "Spider Veloce", 1965, 15000));
            theList.Add(new ClassicCar("Alfa Romeo", "1750 Berlina", 1970, 20000));
            theList.Add(new ClassicCar("Alfa Romeo", "Giuletta", 1978, 45000));

            theList.Add(new ClassicCar("Ford", "Thunderbird", 1971, 35000));
            theList.Add(new ClassicCar("Ford", "Mustang", 1976, 29800));
            theList.Add(new ClassicCar("Ford", "Corsair", 1970, 17900));
            theList.Add(new ClassicCar("Ford", "LTD", 1969, 12000));

            theList.Add(new ClassicCar("Chevrolet", "Camaro", 1979, 7000));
            theList.Add(new ClassicCar("Chevrolet", "Corvette Stringray", 1966, 21000));
            theList.Add(new ClassicCar("Chevrolet", "Monte Carlo", 1984, 10000));

            theList.Add(new ClassicCar("Mercedes", "300SL Roadster", 1957, 19800));
            theList.Add(new ClassicCar("Mercedes", "SSKL", 1930, 14300));
            theList.Add(new ClassicCar("Mercedes", "130H", 1936, 18400));
            theList.Add(new ClassicCar("Mercedes", "250SL", 1968, 13200));
        }
    }
}
