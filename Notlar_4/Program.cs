using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notlar_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            //
            a = 3;
            b = ++a;
            Console.WriteLine(a);//4
            Console.WriteLine(b);//4

            a = 3;
            b = a++;
            Console.WriteLine(a);//4
            Console.WriteLine(b);//3

            a = 3;
            b = ++a + ++a;
            //a önce 4 sonra 5 olur. b-->4 + 5 =9 olur 
            
            a = 3;
            b = ++a + a;
            //a=4, . b=4+ 4=8 olur.

            a = 3;
            b = a++ + a;
            //a=4, b=3+4=7

            //Foo(++a) --> burada a 1 artılırır. metotta kullanılır.
            //Foo(a++)  --> a 1 artılırır ama metoda artmamış hali gönderilir
            Console.ReadKey();
        }
    }
}
