using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus
{
    //OOP
    class StarRhombus
    {
        //atrributes
        public int Size { get; set;}
       //methods
       // print the rhombus of stars
       //print a row with s stars
       private void PrintARowStars(int s) //s: số ngôi sao
        {
            //khoảng trắng = Size-s
            for (int i = 0; i < Size-s; i++)
            {
                Console.Write(" ");
            }
            //in ngôi sao+ khoảng trắng s-1

            for (int i = 0; i < s-1; i++)
            {
                Console.Write("* ");
            }
            //In một ngôi sao
            Console.WriteLine("*"); 

        }
        public StarRhombus(int size)
        {
            Size = size;
        }

        public void PrintRhombusStars()
        {
            //print n row: 1->size
            for (int i = 1; i <= Size; i++)
            {
                PrintARowStars(i);
        
            }
            //print n-1 row: Size-1->1
            for (int i = Size-1; i >0; i--)
            {
                PrintARowStars(i);
          
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the size of Rhombus: ");
            int n = int.Parse(Console.ReadLine());
            StarRhombus st = new StarRhombus(n);
            st.PrintRhombusStars();
            Console.ReadLine();
        }
    }
}
