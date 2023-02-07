using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1._Person
{
    public class Child : Person
    {
        public new int Age
        {
            get { return base.Age; }
            set
            {
                if (value > 15)
                    throw new ArgumentException("Children cannot be more than 15 years old.");
                base.Age = value;
            }
        }
    }
}
