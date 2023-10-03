using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExercise
{
    internal class Sponsor : Person
    {
        private string company;
        private int hiredStudents;

        public Sponsor(string name, int age, string gender, string company) : base(name, age, gender)
        {
            this.company = company;
            this.hiredStudents = 0;
        }

        public Sponsor()
        {
            this.Name = "Jane Doe";
            this.Age = 30;
            this.Gender = "female";
            this.company = "Google";
            this.hiredStudents = 0;
        }

        public string Company { get => company; set => company = value; }
        public int HiredStudents { get => hiredStudents; set => hiredStudents = value; }

        public override void getGoal()
        {
            Console.WriteLine("My goal is: Hire brilliant junior spoftware developers.");
        }

        public override void introduce()
        {
            Console.WriteLine($"Hi, I'm {this.Name}, a {this.Age} year old {this.Gender} who represents {this.company} and hired {this.hiredStudents} students so far.");
        }

        public void hire()
        {
            hiredStudents++;
        }
    }
}
