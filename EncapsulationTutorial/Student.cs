using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationTutorial
{
    internal class Student : Person
    {
        public void DisplayField()
        {
            Console.WriteLine($"Public Field: {PublicField}");
            //Console.WriteLine($"PrivateField: {PrivateField}"); ALT SINIFTAN BİLE ERİŞEMEDİK.
            Console.WriteLine($"ProtectedField: {ProtectedField}"); //ALT SINIFTAN ERİŞEBİLDİK.
            Console.WriteLine($"InternalField: {InternalField}"); //aynı derlemedeyiz, erişebildik.

        }

    }
}
