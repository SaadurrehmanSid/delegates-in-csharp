using System;
using System.Collections.Generic;
namespace UnderstandingDelegates
{
   /// No need for this now...
  /// public delegate bool NotEligibleDelegate(Student student);
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student> {
            new Student{ Id = 1,Name= "Saad ur rehman", attendance=80 },
            new Student{ Id = 2,Name= "Bilal Maqsood", attendance=85 },
            new Student{ Id =3,Name ="Raza liaquat",attendance=66},
            new Student{Id=4, Name="Waleed Ahmad",attendance=54}
            };
            Student.FilterStudents(students,stu => stu.attendance < 75);
        }
    }
    public class Student
    {
        #region Fiels
        public int Id { get; set; }
        public string Name { get; set; }
        public int attendance { get; set; }
        #endregion
        public static void FilterStudents(List<Student> students,Func<Student,bool> notEligibleDelegate)
        {
            foreach (var student in students)
            {
                if (notEligibleDelegate(student))
                {
                    Console.WriteLine(student.Name);
                }
            }
        }
       
    }
}
