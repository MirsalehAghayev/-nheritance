using System;

namespace İnheritanceHomeWorks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student Taleh = new Student

            {
                Grade= 30,
                UserName= "talehagayev",
                Name= "Taleh",
                Surname= "Agayev",
                Password= "xasay123"


            };
            Student Saleh = new Student

            {
                Grade= 50,
                UserName = "salehagayev",
                Name = "Saleh",
                Surname = "Agayev",
                Password = "saleh123"


            };
            Student Yusif= new Student
            {
                Grade = 20,
                UserName = "yusifabilov",
                Name = "Yusif",
                Surname = "Abilov",
                Password = "yusif123"


            };
            Student[] students = { Taleh, Saleh, Yusif };
            Console.WriteLine("Zehmet olmasa User name daxil edin: ");
            string username = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa Password daxil edin: ");
            string password = Console.ReadLine();

            foreach (Student student in students) 
            {
                if (username == student.UserName && password==student.Password)
                {
                    Console.WriteLine(student.Grade);
                }
            }
            
        }
    }
}
