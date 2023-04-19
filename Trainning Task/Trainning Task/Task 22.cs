using System.Text;

namespace Trainning_Task;

public class StringLearn
{
    String str = "He,llo ,w,orld";
    public  void Task22Execute()
    {
        string[] arr = str.Split(',');
        Array.ForEach(arr, x => Console.Write(x + " "));
        Console.WriteLine();
        Console.WriteLine(str.Length);
        Console.WriteLine(str.Substring(3, 7));
        Console.WriteLine(str.IndexOf("o"));
        Console.WriteLine(str.Replace("o", "w"));
        Console.WriteLine(str);
        Console.WriteLine(str.ToUpper());
        Console.WriteLine(string.Concat(str, " im riadh"));
        string[] stringArray = { "I", "love", "Bangladadesh" };
        Console.WriteLine(String.Join(" ",stringArray.ToArray()));
        

    }

    public void Task23Execute()
    {
        StringBuilder stringBuilderObject = new StringBuilder(str);
        Console.WriteLine(stringBuilderObject.Replace("o", "s"));
        Console.WriteLine(stringBuilderObject.Length);
        Console.WriteLine(stringBuilderObject.ToString());
        Console.WriteLine(stringBuilderObject.Remove(2, 3));
        Console.WriteLine(stringBuilderObject.Insert(4, "love"));
        Console.WriteLine(stringBuilderObject.MaxCapacity);

    }
}
