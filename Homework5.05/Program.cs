//доп задача 5 семинар
//Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность (сдвиг - циклический) 
//на |K| элементов вправо, если K – положительное и влево, если отрицательное.
Console.WriteLine("введите количество элементов массива");
int n= Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
Console.WriteLine("введите элементы массива");
for(int i=0; i<array.Length; i++)
{
    array[i]=Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("введите количество элементов сдвига");
int k= Convert.ToInt32(Console.ReadLine());
k=k%n;

int[] array2 = new int[n];

if(k>0)
{
    for(int i=0; i<k; i++)
    {
        array2[i]=array[n-k+i];

    }
    for(int i=0; i<n-k; i++)
    {
        array2[k+i]=array[i];
        
    }
    
    Console.WriteLine($"[{string.Join(", " , array2)}]");

}
else if(k<0)
{
    k=k*(-1);
    for(int i=0; i<k; i++)
    {
        array2[n-k+i]=array[i];

    }
    for(int i=0; i<n-k; i++)
    {
        array2[i]=array[k+i];
        
    }
    
    Console.WriteLine($"[{string.Join(", " , array2)}]");
}