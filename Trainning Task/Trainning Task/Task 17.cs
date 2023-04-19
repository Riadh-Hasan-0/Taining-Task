namespace Trainning_Task
{
    public enum Colour
    {
        green, red, blue
    }
    public class EnumClass
    {
        enum Days
        {
            Sunday,Monday, Tuesday, Wednesday, Thursday, Friday,Saturday
        }
         public static void TaskExecute()
        {
            string colourString = "green";
            Colour colourEnum = (Colour)Enum.Parse(typeof(Colour), colourString);
            Console.WriteLine(colourEnum);
            int colourinteger = 1;
            colourEnum = (Colour)colourinteger;
            Console.WriteLine(colourEnum);
            string str=colourEnum.ToString();
            int value = ((int)colourEnum);
            Console.WriteLine(str);
            Console.WriteLine(value);
        }
    }

    public class EnumClassDemo
    {
        public void task()
        {
            Colour colourEnum = (Colour)1;
            Console.WriteLine(colourEnum);
            
        }
    }
}