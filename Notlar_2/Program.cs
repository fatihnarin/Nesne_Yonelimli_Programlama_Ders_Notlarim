using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notlar_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            result = Sample.Foo() * 2;
            Console.WriteLine(result);
            
            int result1;
            result1 = Sample1.Foo() * 2;
            Console.WriteLine(result1);
            
            int result2;
            result2 = Sample2.Foo();
            Console.WriteLine(result2);

            // Klavyeden değer okuma
            int val;
            Console.WriteLine("Bir değer girin");
            val = int.Parse(Console.ReadLine());
            Console.WriteLine(val * val);

            int a, b, c;

            Console.WriteLine("Bir değer girin");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Bir değer girin");
            b = int.Parse(Console.ReadLine());

            c = a * b;
            Console.WriteLine(c);

            double result3;
            result3 = Sample.Square();
            Console.WriteLine(result3);

            float f = 1e10f;         
            Console.WriteLine(f);

            Console.ReadKey();
        }
    }
    class Sample
    {
        public static int Foo()
        {
            Console.WriteLine("Foo");
            return 100; // return metoru sonlandırır ve geri dönüş değeri oluşturur.
        }

        public static double Square()
        {
            double d;
            Console.WriteLine("Bir değer girin");
            d = int.Parse(Console.ReadLine());

            return d * d;
        }
    }
    class Sample1
    {
        public static int Foo()
        {
            int a = 10;
            Console.WriteLine("Sample1.Foo");
            return a+10;
        }
    }
    class Sample2
    {
        public static int Foo()
        {
            
            Console.WriteLine("Sample2.Foo");
            return Bar() * 2;
        }

        public static int Bar()
        {
            Console.WriteLine("Sample2.Bar");
            return 100;
        }
    }
}
