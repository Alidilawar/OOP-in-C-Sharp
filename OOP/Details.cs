using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
   public class Details
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string getDetails()
        {
            return "First Name is " + FirstName + "Last Name is " + LastName;
        }

        //---------------------------POLYMORPHISM--------------------
        public int Add()
        {
            return 2 + 2;
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public decimal Add(decimal a, decimal b, decimal c)
        {
            return a + b + c;
        }
        //------------------------POLYMORPHISM--------------------------
    }

        public class Student : Details
        {
            public string StudentAddress { get; set; }
        }
        public class Teacher : Details
        {
            public string Subject { get; set; }
        }
}
