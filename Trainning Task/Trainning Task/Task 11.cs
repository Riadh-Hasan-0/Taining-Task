int a = 4, b = 2;
switch (a)
{
    case int value when value < b:
        Console.WriteLine("a is smaller than b");
        break;
    case int value when value > b:
        Console.WriteLine("b is samller than a");
        break;
    default:
        Console.WriteLine("both are equal");
        break;

}