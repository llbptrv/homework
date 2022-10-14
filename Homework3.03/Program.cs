Console.Write("введите пятизначное число: ");
int n=Convert.ToInt32(Console.ReadLine());
int a1=0;
int a2=0;

a1=(n/1000)%10;
a2=(n%100)/10;

if(n/10000==n%10 && a1==a2)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}