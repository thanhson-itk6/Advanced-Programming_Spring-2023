using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_List
{
    internal class CustomRandomList
    {
        public class RandomList : List<string>
        {
            private Random _random = new Random();

            public string RandomString()
            {
                int index = _random.Next(0, Count);
                string item = this[index];
                RemoveAt(index);
                return item;
            }
        }
    }
}
