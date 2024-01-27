using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    public class Student
    {
        private int _Id;
        public string Name;
        public int age;

        public void Setid(int id)
        {
            if (id > 0)
            {
                this._Id = id;
            }
            else
            {
                throw new Exception("Id must not be negitive");
            }
        }

        public int Getid()
        {
            return _Id;
        }

        public void GetStudent()
        {
            Console.WriteLine("Student NAME: {0} ID: {1} AGE: {2}", Name, _Id, age);
        }
    }
    class Properties
    {
        public static void RunProgram()
        {
            Student student = new Student();
            student.Setid(2000);
            student.Name = "sravani";
            student.age = 18;
            student.GetStudent();
            Console.WriteLine(student.Getid());
        }
    }
}
