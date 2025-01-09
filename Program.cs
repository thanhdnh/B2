using System.Formats.Tar;

public class Program
{
    public static Array GenericGenArray<T>(int len){
        Array arr = Array.CreateInstance(
            typeof(T),
            new int[]{5},
            new int[]{0}
        );
        Random rand = new Random(100);
        for(int i=0; i<len-1; i++)
            arr.SetValue(rand.Next(1, 100), i);
        return arr;
    }
    public static Array GenArray(int len){
        Array arr = Array.CreateInstance(
            typeof(Int32),
            new int[]{len},
            new int[]{0}
        );
        Random rand = new Random(100);
        for(int i=arr.GetLowerBound(0); i<=arr.GetUpperBound(0); i++)
            arr.SetValue(rand.Next(1, 100), i);
        for(int i=arr.GetLowerBound(0); i<=arr.GetUpperBound(0); i++)
            Console.Write(arr.GetValue(i)+", ");
        return arr;
    }
    public static Array Gen2DArray(int len1, int len2){
        Array arr = Array.CreateInstance(
            typeof(Int32),
            new int[]{len1, len2},
            new int[]{0, 0}
        );
        Random rand = new Random(100);
        for(int i=arr.GetLowerBound(0); i<=arr.GetUpperBound(0); i++)
            for(int j=arr.GetLowerBound(1); j<=arr.GetUpperBound(1); j++)
                arr.SetValue(rand.Next(1, 100), i, j);//arr[i, j] = ?
        /*for(int i=arr.GetLowerBound(0); i<=arr.GetUpperBound(0); i++)
            Console.Write(arr.GetValue(i)+", ");*/
        return arr;
    }
    public static int SumArray(Array arr){
        int sum = 0;
        foreach(int i in arr)
            sum += i;
        return sum;
    }
    public static int Sum2DArray(Array arr){
        int sum = 0;
        
        return sum;
    }
    public static void Main(string[] args)
    {
        /* int[] arr = new int[5];
        arr[0] = 3; arr[1] = 5; arr[2] = 7; 
        arr[3] = 9; arr[4] = 11;*/
        Array arr = GenArray(5);
        Console.WriteLine("Sum: " + SumArray(arr));
        
        //arr.GetValue(index)
        //arr.SetValue(value, index)
        
    }
}