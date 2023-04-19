//single line comment
int a = 3, b = 4, c = 5;
int temp;
temp = a;
/*multi 
 * line 
 * commnet*/
a=(a<b?a:b);
temp=(temp==a?b:temp);
b=(temp<c?temp:c);
c=(temp==b?c:temp);
Console.WriteLine(a+" "+b+" "+c);