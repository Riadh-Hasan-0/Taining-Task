using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainning_Task
{
    public class Task_15___16
    {
        //Task 15
        int[] integerArray = new int[15];
        bool[] booleanArray = new bool[15];
        char[] charArray = new char[15];
        long[] longArray = new long[15];
        double[] doubleArray = new double[15];
        string[] stringArray = new string[15];

        //Task 16
        public void TaskExecute()
        {
            int i;
            for (i = 0; i < 15; i++)
            {
                if (i == 5) continue;
                if (i == 10) break;
                integerArray[i] = i;
                booleanArray[i] = false;
                charArray[i] = 'u';
                longArray[i] = i;
                doubleArray[i] = i;
                stringArray[i] = "demo";
                Console.WriteLine(integerArray[i] + " " + booleanArray[i] + " " + charArray[i] + " " + longArray[i] +" " + doubleArray[i] + " " + stringArray[i]);
            }

            i = 0;
            while (i < 15)
            {
                if (i == 5)
                {
                    i++;
                    continue;
                }

                if (i == 10) break;
                integerArray[i] = i;
                booleanArray[i] = false;
                charArray[i] = 'u';
                longArray[i] = i;
                doubleArray[i] = i;
                stringArray[i] = "demo";
                Console.WriteLine(integerArray[i] + " " + booleanArray[i] + " " + charArray[i] + " " + longArray[i] + " " + doubleArray[i] + " " + stringArray[i]);

                i++;
            }

            i = 0;
            do
            {
                if (i == 5)
                {
                    i++;
                    continue;
                }

                if (i == 10) break;
                integerArray[i] = i;
                booleanArray[i] = false;
                charArray[i] = 'u';
                longArray[i] = i;
                doubleArray[i] = i;
                stringArray[i] = "demo";
                Console.WriteLine(integerArray[i] + " " + booleanArray[i] + " " + charArray[i] + " " + longArray[i] + " " + doubleArray[i] + " " + stringArray[i]);

                i++;
            } while (i < 15);

            foreach (int x in Enumerable.Range(0, 15))
            {
                if (i == 5)
                {
                    continue;
                }

                if (i == 10) break;
                integerArray[i] = i;
                booleanArray[i] = false;
                charArray[i] = 'u';
                longArray[i] = i;
                doubleArray[i] = i;
                stringArray[i] = "demo";
                Console.WriteLine(integerArray[i] + " " + booleanArray[i] + " " + charArray[i] + " " + longArray[i] + " " + doubleArray[i] + " " + stringArray[i]);


            }
        }
    }
}
