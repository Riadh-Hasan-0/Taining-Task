namespace Trainning_Task;

public class Arraylearn
{
    public int[] integerArray = { 5, 65, 6, 4, 1, 5, 7, 12, 43, 9 };
    String[] stringArray = { "riadh", "tausif", "Ria", "Rafid", "Samia", "Galib" };
    private double[] doubleArray = { 5, 56.5, 5644.78, 45564.545, 154.1, 64.98 };
    public  void TaskExecute()
    {
        integerArray.Distinct();
        Console.WriteLine(integerArray.Sum(x => x));
        Console.WriteLine(integerArray.Length);
        Console.WriteLine(integerArray.Rank);
        integerArray.Reverse();
        Array.Sort(integerArray);
        Array.ForEach(integerArray, x => Console.Write(x + " "));
        Console.WriteLine();
        Console.WriteLine(Array.BinarySearch(integerArray, 5));
        Array.Resize(ref integerArray, 5);
        Array.ForEach(integerArray, x => Console.Write(x + " "));
        Console.WriteLine();
        
    }
}
