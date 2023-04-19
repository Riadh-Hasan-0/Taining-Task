int a = 4, b = 2, c = 5;
if (a < b)
{
    if (a < c)
    {
        if (c < b) Console.WriteLine(a + " " + c + " " + b);
        else Console.WriteLine(a + " " + b + " " + c);
    }
    else
    {
       Console.WriteLine(c + " " + a + " " + b);
    }
}
else if (a < c)
{
        Console.WriteLine(b + " " + a + " " + c);
}
else
{
    if(c < b) Console.WriteLine(c + " " + b + " " + a);
    else Console.WriteLine(b + " " + c + " " + a);
}