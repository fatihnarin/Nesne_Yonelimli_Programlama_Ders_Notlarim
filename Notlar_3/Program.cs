using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notlar_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 20;
            Sample.Foo(x, y);
            Sample.Foo(x+10, y-5);
            Sample.Foo(100, 200);

            double result;

            result = MathOp.Add(10 , 20);
            Console.WriteLine(result);

            result = MathOp.Mul(10 , 20);
            Console.WriteLine(result);
           
            result = MathOp.Div(10, 20);
            Console.WriteLine(result);
          
            result = MathOp.Square(10);
            Console.WriteLine(result);

            double val, result1;

            Console.WriteLine("Lütfen bir sayı girinniz :");
            val=double.Parse(Console.ReadLine());

            result1 = Math.Sqrt(val);// karakök alma
            Console.WriteLine(result1);

            result1 = Math.Pow(2,10);// üs alma
            Console.WriteLine(result1);

            //Sin, Cos, Tan, ASin, ACos, ATan, Log

            result = 20 % 7*2;// % mod  alır
            Console.WriteLine(result);

            // Klavyenen girilen sayıya en yakın 4'ün katını bulma
            Console.WriteLine("Bir sayı giriniz: ");

            int gir = int.Parse(Console.ReadLine());
            int sonuc = gir - gir%4;            
            Console.WriteLine("sonuç :{0}", sonuc);

            double a, b, c;
            
            Console.WriteLine("a: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("b: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("c: ");
            c = double.Parse(Console.ReadLine());

            Root.DispRoots(a, b, c);
            
            Console.ReadKey();
        }
    }
    class Sample
    {
        public static void Foo(int a, int b)
        {
            Console.WriteLine(a + "," + b);

            //long a = 100; metottaki paremetle ile aynı isimli başka bir yerel değişken tanımlanamaz.
            a = 100;
            b = 100;

            Console.WriteLine(a + "," + b);
        }

    }
    class MathOp
    {
        public static double Add(int a, int b)
        {
            return a + b;
        }
        public static double Mul(int a, int b)
        {
            return a * b;
        }
        public static double Div(double a, double b)
        {
            return a / b;
        }
        public static double Square(int a)
        {
            return a * a;
        }
    }
    class Root
    {
        public static void DispRoots(double a, double b, double c)
        {
            double delta;
            double x1, x2;
            
            delta = b * b - 4 * a * c;
            x1 = (-b + System.Math.Sqrt(delta)) / (2 * a);
            x2 = (-b - System.Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine(x1);
            Console.WriteLine(x2);

        }
    }
}
