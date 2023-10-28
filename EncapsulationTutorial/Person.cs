using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationTutorial
{
    internal class Person
    {
        public int PublicField; //her yerden erişilebilir
        private int PrivateField; //sadece bu sınıf içerisinde erişilebilir

        protected int ProtectedField; //alt sınıflardan erişilebilir
        internal int InternalField; //aynı derleme içerisinde erişilebilir (NAMESPACE içinden)
        protected internal int ProtectedInternalField;
        public void BaseDisplayField()
        {
            Console.WriteLine($"Public Field: {PublicField}");
            Console.WriteLine($"PrivateField: {PrivateField}"); //ALT SINIFTAN BİLE ERİŞEMEDİK.
            Console.WriteLine($"ProtectedField: {ProtectedField}"); //ALT SINIFTAN ERİŞEBİLDİK.
            Console.WriteLine($"InternalField: {InternalField}"); //aynı derlemedeyiz, erişebildik.
            Console.WriteLine($"ProtectedInternalField: {ProtectedInternalField}");
        }

    }
}
