using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExercise
{
    internal class Cohort
    {
        private string name;
        private List<Student> students;
        private List<Mentor> mentors;

        public Cohort(string name)
        {
            this.name = name;
            this.students = new List<Student>();
            this.mentors = new List<Mentor>();
        }

        public void addStudent(Student student)
        {
            students.Add(student);
        }

        public void addMentor(Mentor mentor)
        {
            mentors.Add(mentor);
        }

        public void info()
        {
            Console.WriteLine($"The {name} cohort has {students.Count} students and {mentors.Count} mentors.");
        }
    }
}
