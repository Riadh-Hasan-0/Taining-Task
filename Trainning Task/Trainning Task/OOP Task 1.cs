using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Trainning_Task
{
    public static class StaticClass
    {
        public static int integervalue { get; set; }
        private static string stringvalue;
        public static int Multipleof4(int number)
        {
            return number * 4;
        }

    }

    public class Person
    {
        //Task 1
        public int age { get; set; }
        private string name;
        protected string fathersName, mothersName;
        private string address;
        public static int totalNumberOfPerson = 0;

        public bool IsTeenager()
        {
            return this.age > 18;
        }

        private void IncrementAge()
        {
            this.age++;
        }
        protected string GetAdress()
        {
            return this.address;
        }

        //defaul issuse
        public Person() { }
        //Task 2
        private Person(int age)
        {
            this.age = age;
        }

        protected Person(string fathersName, string mothersName)
        {
            this.fathersName = fathersName;
            this.mothersName = mothersName;
        }
        public Person(int age, string name, string fathersName, string mothersName)
            : this(fathersName, mothersName)
        {
            this.name = name;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine(this.fathersName + " " + this.mothersName + " " + this.name + " " + this.age + " " + this.address);
        }
    }
    public class Student : Person
    {
        public int studentRoll { get; set; }
        public List<string> courseList;

        public Student(){
            
            courseList = new List<string>();
        }
        //Task 4
        public Student(int studentRoll,int name):
            this()
        {
            this.studentRoll = studentRoll;
        }
        //
        public Student(int studentRoll,int age,string name,string fatherName,string motherName)
                :base(fatherName,motherName)
        {
            
            this.studentRoll =studentRoll;
            this.age = age;
        }

        public override void PrintInfo()
        {
            Console.WriteLine(this.age+" "+this.fathersName+" "+this.studentRoll);
        }
    }
    
}
