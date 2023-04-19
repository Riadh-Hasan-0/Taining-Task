using System;

namespace Trainnng_Task
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            //task 4
            string s = "5";
            int a =Convert.ToInt32(s);
            Console.WriteLine(s + "  " + a);
            a = 10;
            s=Convert.ToString(a);
            Console.WriteLine(s + " " + a);

            s = "5";
            long b= Convert.ToInt64(s);
            Console.WriteLine(s + " " + b);
            b = 234234;
            s= Convert.ToString(b); ;
            Console.WriteLine(s + " " + b);
            s= "5.99";
            double d = Convert.ToDouble(s);
            Console.WriteLine( s + " " + d);
            d = 3434.23239979779787867;
            s = Convert.ToString(d);
            Console.WriteLine(s + " " + d);
            s = "3.4";
            float f = Convert.ToSingle(s);
            Console.WriteLine(s+" " + f);
            f = 3;
            s = Convert.ToString(f);
            Console.WriteLine(s+ " "+ f);
            s = "True";
            bool g= Convert.ToBoolean(s);
            Console.WriteLine(s + " x" + g); 
            g= Convert.ToBoolean(s);
            Console.WriteLine(s + " " + g);
            a = int.MaxValue;
            long l= Convert.ToInt64(a)+10;
            Console.WriteLine(a+" "+l);
            a = Convert.ToInt32(l);
            Console.WriteLine(l+" "+a);
            a = 65;
            char ch= Convert.ToChar(a);
            Console.WriteLine(ch+" "+a);
            a= Convert.ToInt32(ch+1);
            Console.WriteLine(ch+" "+a);
        }
    }
}
