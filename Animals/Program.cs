using System;
using System.Collections.Generic;
using System.Linq;
using Animals;

namespace Animals
{
    public class Program
    {
        public static void Main(string[] args)
        {

            List<Animal> animals = new List<Animal>
            {
                new Animal { Name = "Alfons", Type = "Rabbit", Age = 3, IsVaccinated = true, Legs = 4, Gender = Gender.Male },
                new Animal { Name = "Atlas", Type = "Dog", Age = 7, IsVaccinated = true, Legs = 4, Gender = Gender.Male },
                new Animal { Name = "Stella", Type = "Cat", Age = 10, IsVaccinated = true, Legs = 4, Gender = Gender.Female },
                new Animal { Name = "Nugget", Type = "Cat", Age = 2, IsVaccinated = true, Legs = 4, Gender = Gender.Female },
                new Animal { Name = "Shadow", Type = "Dolphin", Age = 5, IsVaccinated = false, Legs = 0, Gender = Gender.Male }, 
                new Animal { Name = "Oscar", Type = "Human", Age = 24, IsVaccinated = true, Legs = 2, Gender = Gender.Male },
                new Animal { Name = "Trixxa", Type = "Dog", Age = 15, IsVaccinated = true, Legs = 4, Gender = Gender.Female },
                new Animal { Name = "Glenn", Type = "Cat", Age = 8, IsVaccinated = true, Legs = 4, Gender = Gender.Male },
                new Animal { Name = "James", Type = "Cat", Age = 7, IsVaccinated = true, Legs = 4, Gender = Gender.Male },
                new Animal { Name = "Gabbie", Type = "Cat", Age = 7, IsVaccinated = true, Legs = 4, Gender = Gender.Female },
                new Animal { Name = "Pawwot", Type = "Parrot", Age = 14, IsVaccinated =false, Legs = 2, Gender = Gender.Male },
                new Animal { Name = "Billy", Type = "Dog", Age = 10, IsVaccinated = true, Legs = 4, Gender = Gender.Male  }
            };

            int numberOfDogs = animals.Count(a => a.Type == "Dog");
            Console.WriteLine($"Antal hundar: {numberOfDogs}");

            Animal oldestAnimal = animals.OrderByDescending(a => a.Age).FirstOrDefault();
            Console.WriteLine($"Äldsta djuret: {oldestAnimal?.Name}, Ålder: {oldestAnimal?.Age}");

            var oldestMale = animals.Where(a => a.Gender == Gender.Male).OrderByDescending(a => a.Age).FirstOrDefault();
            
            var oldestFemale = animals.Where(a => a.Gender == Gender.Female).OrderByDescending(a => a.Age).FirstOrDefault();
            Console.WriteLine($"Äldsta hanen {oldestMale?.Name}, Kön: {GetGenderInSwedish(oldestMale?.Gender)}, Ålder: {oldestMale?.Age}");
            Console.WriteLine($"Äldsta honan {oldestFemale?.Name}, Kön: {GetGenderInSwedish(oldestFemale?.Gender)}, Ålder  { oldestFemale?.Age}");
            var vaccinatedAnimals = animals.Where(a => a.IsVaccinated).ToList();
            Console.WriteLine("Vaccinerade djur:");
            vaccinatedAnimals.ForEach(a => Console.WriteLine(a.Name));

            var animalsWith4LegsOver3Years = animals.Where(a => a.Legs == 4 && a.Age > 3).ToList();
            Console.WriteLine("Djur med 4 ben och över 3 år gamla:");
            animalsWith4LegsOver3Years.ForEach(a => Console.WriteLine(a.Name));

            bool hasShadow = animals.Any(a => a.Name == "Shadow");
            Console.WriteLine($"Finns det ett djur som heter Shadow? {ConvertBoolToSwedish(hasShadow)}");
        }
        public static string GetGenderInSwedish(Gender? gender)
        {
            return gender switch
            {
                Gender.Male => "Hane",
                Gender.Female => "Hona",
                _ => "Okänt"

            };
        }
        public static string ConvertBoolToSwedish(bool value)
        {
            return value ? "Ja" : "Nej";
        }
    }
}

