using System;

namespace prac2a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            Object boxed = num;
            Console.WriteLine("Boxed value: " + boxed);
            int unboxed = (int)boxed;
            Console.WriteLine("Unboxed value: " + unboxed);
            num = 200;
            Console.WriteLine("Original value after modification: " + num); // Corrected the spelling of "Original"
            Console.WriteLine("Boxed value remain unchanged: " + boxed);
            Console.ReadKey();
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace prac2b
{
 public delegate int MathOperation(int x, int y );
 internal class Program
    {
 public static int Add(int a , int b)
 {
 return a + b;
 }
 public static int Subtract(int a , int b) { return a - b; }
 static void Main(string[] args)
 {
 MathOperation operation = Add;
 Console.WriteLine("\tAddition: "+operation(10,10));
 operation=Subtract;
 Console.WriteLine("\tSubtraction: "+operation(50,20));
 Console.ReadKey();
 }
 }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace prac2c
{
 interface abc
 {
 void Adding(int x, int y);
 }
 interface bcd
 {
 void show();
   }
 class Test:abc,bcd
 {
 public void Adding(int a,int b)
 {
 Console.WriteLine("Addition is: "+(a + b));
 }
 public void show()
 {
 Console.WriteLine("show of test from abc");
 }
 }
 internal class Program
 {
 static void Main(string[] args)
 {
 abc a1;
 a1=new Test();
 a1.Adding(10, 10);
 bcd b1=(bcd)a1;
 b1.show();
 Console.ReadKey();
 }
 }
}
