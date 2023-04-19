using System;

namespace Trainnng_Task
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            //task 3
            int a = int.MaxValue;
            try
            {
                checked
                {
                    Console.WriteLine(a + 1);
                }
            }
            catch (Exception)
            {

                Console.WriteLine("overflow");
            }
           


        }
    }
}
