int n= Convert.ToInt32(Console.ReadLine());
int m= Convert.ToInt32(Console.ReadLine());
int i=0;
int result=1;

while(i<m)
{
    result=result*n;
    i++;
}

Console.WriteLine(result);
