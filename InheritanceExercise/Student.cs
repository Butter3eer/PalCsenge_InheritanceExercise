using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExercise
{
    internal class Student : Person
    {
        private string previousOrganization;
        private int skippedDays;

        public Student(string name, int age, string gender, string previousOrganization) : base(name, age, gender)
        {
            this.previousOrganization = previousOrganization;
            this.skippedDays = 0;
        }

        public Student()
        {
            this.Name = "Jane Doe";
            this.Age = 30;
            this.Gender = "female";
            this.previousOrganization = "The School of Life";
            this.skippedDays = 0;
        }

        public string PreviousOrganization { get => previousOrganization; set => previousOrganization = value; }
        public int SkippedDays { get => skippedDays; set => skippedDays = value; }

        public override void getGoal()
        {
            Console.WriteLine("My goal is: Be a junior spoftware developer.");
        }

        public override void introduce()
        {
            Console.WriteLine($"Hi, I'm {this.Name}, a {this.Age} year old {this.Gender} from {previousOrganization} who skipped {skippedDays} days from the course already.");
        }

        public void skipDays(int numberOfDays)
        {
            skippedDays += numberOfDays;
        }
    }
}
