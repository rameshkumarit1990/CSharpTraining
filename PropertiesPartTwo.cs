using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{

    public class StudentPropertiesTwo
    {
        private int _ID;
        private string? _Name;
        private string _LastName;
        private int _PassMark;

        public int ID
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Number should be greater than 0");
                }
                this._ID = value;

            }
            get
            {
                return this._ID;
            }
        }

        public int PassMark
        {
            set
            {
                if (value <= 35)
                {
                    throw new Exception("Pass mark is 35 enter greater than 35.");
                }
                this._PassMark = value;

            }
            get
            {
                return this._PassMark;
            }
        }

        public string Name
        {
            set { this._Name = value; }
            get { return this._Name; }
        }

        public string LastName { get; set; }

    }
    class PropertiesPartTwo
    {
        public static void RunProgram()
        {
            Console.WriteLine("Enter id,marks,name");
            StudentPropertiesTwo s = new StudentPropertiesTwo();
            s.ID = Convert.ToInt16(Console.ReadLine());
            s.PassMark = Convert.ToInt16(Console.ReadLine()); ;
            s.Name = Console.ReadLine();
            string abc = Console.ReadLine();
            s.LastName = string.IsNullOrEmpty(abc) ? throw new Exception("should not be null") : abc;
            Console.WriteLine("Entered values {0}, {1}, {2}, {3}", s.ID, s.Name, s.PassMark, s.LastName);
        }
    }
}
