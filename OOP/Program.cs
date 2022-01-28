using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstraction: what is necessary or what is essential for any module known is abstraction.
            //Encapsulation: We have to minimize the Logic Complexity called Encapsulation.
            //inheritance: 
            //Polymorphism: One thing many forms.


            Order order = new Order();
            order.OrderNo = "123";
            order.OrderValue = "1000";
            order.OrderCountry = "Pakistan";

            order.CreatedOrder();
            Console.ReadLine();

            Student student = new Student();
            student.FirstName = "first Name";
            student.LastName = "last Name";
            student.StudentAddress = "student Address";
            student.getDetails();

            Teacher teacher = new Teacher();
            teacher.FirstName = " T F Name";
            teacher.LastName = " T L Name";
            teacher.Subject = "Maths";
            teacher.getDetails();

        }
    }
}
