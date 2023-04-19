namespace Trainning_Task;

struct PersonStructure
{
    public int age;
    public string name;
    public void GetInfo()
    {
        Console.WriteLine(this.name+" "+this.age);
    }
}