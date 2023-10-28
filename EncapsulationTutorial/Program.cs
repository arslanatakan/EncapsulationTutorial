using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine("BaseClass:");
            person.BaseDisplayField();
            
            Student student = new Student();
            Console.WriteLine("Student Class:");
            student.DisplayField();
            //protectedInternal incele.






            Console.ReadLine();
            
        }
    }
}
