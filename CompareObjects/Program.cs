using CompareObjects.Models;
using Newtonsoft.Json;
using ObjectCompare;
using System;
using System.Collections.Generic;

namespace CompareObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer dev1 = new Developer()
            {
                DeveloperID = 1,
                FirstName = "John",
                LastName = "Wick",
                Skills = new List<Skill>()
                {
                    new Skill() { SkillID = 1, SkillName = "PHP" },
                    new Skill() { SkillID = 2, SkillName = "jQuery" }
                }
            };

            Developer dev2 = new Developer()
            {
                DeveloperID = 1,
                FirstName = "John",
                LastName = "Wick",
                Skills = new List<Skill>()
                {
                    new Skill() { SkillID = 1, SkillName = "PHP" },
                    new Skill() { SkillID = 2, SkillName = "jQuery" }
                }
            };

            Developer dev3 = new Developer()
            {
                DeveloperID = 2,
                FirstName = "Johnny",
                LastName = "English",
                Skills = new List<Skill>()
                {
                    new Skill() { SkillID = 1, SkillName = "C#" },
                    new Skill() { SkillID = 2, SkillName = "Entity Framework" }
                }
            };

            bool isEqual = ObjectComparer.Equals(dev1, dev2);

            Console.WriteLine(GetConsoleMessage(isEqual, "Dev1 compare Dev2"));

            isEqual = ObjectComparer.Equals(dev1, dev3);

            Console.WriteLine(GetConsoleMessage(isEqual, "Dev1 compare Dev3"));

            string dev1JsonString = JsonConvert.SerializeObject(dev1);
            string dev2JsonString = JsonConvert.SerializeObject(dev2);
            string dev3JsonString = JsonConvert.SerializeObject(dev3);

            isEqual = dev1JsonString.Equals(dev2JsonString);

            Console.WriteLine(GetConsoleMessage(isEqual, "Dev1 compare Dev2 (Json)"));

            isEqual = dev1JsonString.Equals(dev3JsonString);

            Console.WriteLine(GetConsoleMessage(isEqual, "Dev1 compare Dev3 (Json)"));

            Console.ReadKey();
        }

        private static string GetConsoleMessage(bool isEqual, string message)
        {
            return string.Format("{0}: {1}", message, isEqual ? "Objects are equal" : "Objects are not equal");
        }
    }
}
