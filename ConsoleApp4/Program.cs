using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
       
            five();

            Console.Read();
        }
        static void one() { Console.WriteLine("1  2  3"); }
        static void two()
        {
            Console.WriteLine("5");

            Console.WriteLine("10");

            Console.WriteLine("21");
        }
        static void three() {
            int b;
            string a;
            a = Console.ReadLine();
            int cm;
            cm = int.Parse(a);
            b = cm / 100;
            Console.WriteLine(b);
        }
        static void four()
        {
            int b = 234;

            Console.WriteLine(b / 7);

        }
        static void five()
        {
            int b;
            string a;
            a = Console.ReadLine();
            int q;
            q = int.Parse(a);
            int tens;
            tens = q / 10;
            int second;
            second = q - (tens * 10);
            Console.WriteLine("the num of 10");
            Console.WriteLine(tens);
            Console.WriteLine("the num of 1");
            Console.WriteLine(second);
            Console.WriteLine("the summ");
            Console.WriteLine(second + tens);
            Console.WriteLine("the mult");
            Console.WriteLine(second * tens);
        }
        static void six()
        {
            bool b = false;
            bool a = true;
            bool c = false;
            bool f = a || b;
            bool second = a & b;
            bool three = b || c;
            Console.WriteLine(f);
            Console.WriteLine(second);
            Console.WriteLine(three);
        }
        static void seven()
        {
            string r;
            r = Console.ReadLine();
            int q;
            q = int.Parse(r);
            string a;
            a = Console.ReadLine();
            int w;
            double p = 3.14;
            w = int.Parse(a);
            int sq = w * w;
            double ss = q * q * p;
            if (sq > ss)
            {
                Console.WriteLine("square bigger");

            }
            else
            {
                Console.WriteLine("circle is bigger");
            }
        }
        static void eight()
        {
            Console.WriteLine("Write mass and volume of the first body");
            string r;
            r = Console.ReadLine();
            int q;
            q = int.Parse(r);
            string a;
            a = Console.ReadLine();
            int w;
            w = int.Parse(a);
            Console.WriteLine("Write mass and volume of the second body");

            string e;
            e = Console.ReadLine();
            int t;
            t = int.Parse(r);
            string y;
            y = Console.ReadLine();
            int u;
            u = int.Parse(y);
            int sq = q / w;
            double ss = t / u;
            if (sq > ss)
            {
                Console.WriteLine("first denser");

            }
            else
            {
                Console.WriteLine("second denser");
            }
        }
        static void nine()
        {/*формула тока=U/R*/
            Console.WriteLine("Write U and R of the first");
            string r;
            r = Console.ReadLine();
            int q;
            q = int.Parse(r);
            string a;
            a = Console.ReadLine();
            int w;
            w = int.Parse(a);
            Console.WriteLine("Write U and R of the second body");

            string e;
            e = Console.ReadLine();
            int t;
            t = int.Parse(r);
            string y;
            y = Console.ReadLine();
            int u;
            u = int.Parse(y);
            int sq = q / w;
            double ss = t / u;
            if (sq < ss)
            {
                Console.WriteLine("first lower");

            }
            else
            {
                Console.WriteLine("second lower");
            }
        }
        static void ten(){

            int a = 35;
            for (int i = 25; i < a; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(i + 1);

            }
        }
    }
}
