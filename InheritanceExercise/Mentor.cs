using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InheritanceExercise
{
    internal class Mentor : Person
    {
        private string level;

        public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
        {
            this.level = level;
        }

        public Mentor() 
        {
            this.Name = "Jane Doe";
            this.Age = 30;
            this.Gender = "female";
            this.level = "intermediate";
        }

        public string Level { get => level; set => level = value; }

        public override void getGoal()
        {
            Console.WriteLine("My goal is: Educate brilliant junior spoftware developers.");
        }

        public override void introduce()
        {
            Console.WriteLine($"Hi, I'm {this.Name}, a {this.Age} year old {this.Gender} {this.level} mentor.");
        }
    }
}
