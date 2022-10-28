double[] array = new double[4];
for(int i=0; i<array.Length; i++)
{
    array[i]=Math.Round(new Random().NextDouble()*100, 2);
}
Console.WriteLine($"[{string.Join(", " , array)}]");


double maxPosition=array[0];
double minPosition=array[0];
for(int i=1; i<array.Length; i++)
{
   
    if(array[i]>maxPosition) maxPosition=array[i];
    else if (array[i]< minPosition) minPosition=array[i];

}
Console.Write("максимум: ");
Console.WriteLine(maxPosition);
Console.Write("минимум: ");
Console.WriteLine(minPosition);
Console.WriteLine($"разница между максимумом и минимумом: {maxPosition - minPosition}");
