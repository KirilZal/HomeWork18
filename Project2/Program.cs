using Library1;
using System.Reflection.Metadata;

namespace Project2
{
    class DerivedClass: Library
    {
       //public void Use()
       // {
       //     Method();
       // }
       static void Main(string[] args)
        {

            DerivedClass derived = new DerivedClass();
            derived.Method();
        }
    }

   
}
