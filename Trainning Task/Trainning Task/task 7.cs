int a = 4, b = 3, c = 5;
if (a < b && c < b)
{
    if (a < c) Console.WriteLine(a + " " + c + " " + b);
    else Console.WriteLine(c + " " + a + " " + b);

}
else if (a < c && b < c)
{
    if (a < b) Console.WriteLine(a + " " + b + " " + c);
    else Console.WriteLine(b + " " + a + " " + c);
}
else
{
    if(b<c) Console.WriteLine(b + " " + c + " " + a); 
    else Console.WriteLine(c + " " + b + " " + a);
}