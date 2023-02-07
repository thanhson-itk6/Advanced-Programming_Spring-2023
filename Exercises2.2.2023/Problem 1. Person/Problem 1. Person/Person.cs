using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1._Person
{
   
        public class Person
        {
            private int age;

            public int Age
            {
                get { return age; }
                set
                {
                    if (value < 0)
                        throw new ArgumentException("Age cannot be negative.");
                    age = value;
                }
            }
        }

      

   
}
