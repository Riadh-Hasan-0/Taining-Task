
namespace Trainning_Task
{
    public class Task
    {
        public static void Main()
        {
            //Task 12
            PersonClass personClassObj1 = new PersonClass() { age = 21, name = "riadh" };
            personClassObj1.PrintInfo();
            //Task 13
            PersonStructure personStructureObj1;
            personStructureObj1.age = 10;
            personStructureObj1.name = "Tausif";
            personStructureObj1.GetInfo();

            //Task 14
            PersonClass personClassObj2 = personClassObj1;
            personClassObj2.name = "Samia";
           /* we changed the name value of personClassObj2 but if we see the output
             * we can see name value of personClassObj1 is also changed
*/

             Console.WriteLine(personClassObj2.age + " " + personClassObj1.name);
            int number1 = 3;
            int number2 = number1;
            number2 = 10;
            Console.WriteLine(number1);


            //Task 15 & 16
            Task_15___16 taskobject1 = new Task_15___16();
            taskobject1.TaskExecute();
            // Task 17
            EnumClass.TaskExecute();

            //Task 18
            ClassWithStaticMethod.print();
            ClassWithNonStaticMethod nonStaticCLassObject = new ClassWithNonStaticMethod();
            nonStaticCLassObject.print();

            //Task 19
            List<int> listOfInterger = new List<int>();
            List<string> listOfString = new List<string>();
            List<double> listOfDoubles = new List<double>();
            listOfInterger.Add(0);
            listOfInterger.Add(1);
            listOfInterger.Add(2);
            int[] arrayForListConversion = { 5, 3, 6 };
            listOfInterger.AddRange(arrayForListConversion);
            listOfInterger.Remove(3);
            listOfInterger.RemoveAt(3);
            listOfInterger.RemoveRange(0, 1);
            listOfInterger.Insert(0, 2);
            listOfInterger.Reverse();
            listOfInterger.Sort();
            listOfInterger.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
            Console.WriteLine(listOfInterger.BinarySearch(6));
            arrayForListConversion = listOfInterger.ToArray();
            foreach (var i in arrayForListConversion) Console.Write(i + " ");
            Console.WriteLine();
            listOfInterger.Clear();

            //Task 20
            Arraylearn arrayLearnObject = new Arraylearn();
            arrayLearnObject.TaskExecute();

            //Task 21
            DateTime dateTimeobject = DateTime.Now;
            Console.WriteLine(dateTimeobject.Hour + " " + dateTimeobject.Minute + " " + dateTimeobject.Second);
            Console.WriteLine(DateTime.Parse(dateTimeobject.ToString()));
            Console.WriteLine(DateTime.IsLeapYear(2024));
            Console.WriteLine(dateTimeobject.DayOfWeek);

            TimeSpan timeSpanObject = new TimeSpan(5, 0, 20);
            Console.WriteLine(timeSpanObject.ToString());
            timeSpanObject = timeSpanObject.Subtract(new TimeSpan(2, 4, 9));
            Console.WriteLine(timeSpanObject.ToString());

            //Task 22
            StringLearn stringLearnObject = new StringLearn();
            stringLearnObject.Task22Execute();

            //Task 23

            stringLearnObject.Task23Execute();


            //OOP

            //Task 1
            StaticClass.integervalue = 10;
            Console.WriteLine(StaticClass.Multipleof4(10));

            Student studentObject = new Student(19, 14, "Riadh", "pinky");
            studentObject.PrintInfo();

            //Task 3
            //Upcasting
            Person personObject = (Person)studentObject;

            Console.WriteLine(personObject.age);

            Student studentObject2=personObject as Student;
            if (studentObject2 != null)
            {
                Console.WriteLine("Downcasting successfull");

            }

            studentObject.PrintInfo();
            Person personObjectX = new Person();
            personObjectX = personObject;
            personObjectX.PrintInfo();

        }
    }
}

