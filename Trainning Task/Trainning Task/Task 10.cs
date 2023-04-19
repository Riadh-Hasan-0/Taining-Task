int i;
for ( i = 1; i < 101; i++)
{
    if (i == 95) continue;
    if (i == 99) break;
    Console.Write(i + " ");
}
Console.WriteLine();
i = 0;
while (i < 100) { 
    i++;
    if (i == 95) continue;
    if (i == 99) break;
    Console.Write(i + " ");
}
Console.WriteLine();
i = 0;
do
{
    i++;
    if (i == 95) continue;
    if (i == 99) break;
    Console.Write(i + " ");
} while (i < 101);
Console.WriteLine();
foreach (var x in Enumerable.Range(1, 100))
{
    if (x == 95) continue;
    if (x == 99) { break; }
    Console.Write(x+" ");
}
