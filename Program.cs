//1.
int[] array = new int[] {1,2,3,4,5,6};
int sum = array.Sum();
Console.WriteLine(sum);

//2
string s=Console.ReadLine();
string [] a= s.Split(' ');
double x = 0;
foreach (var i in a)
{
    x += Convert.ToInt32(i);
}
double sr = x / a.Length;
Console.WriteLine(sr);
//3
int[] myArray = new[] { 234, 34, 78, 92, 465 };
int value = myArray[0];
for (int i = 1; i < myArray.Length; i++)
    if (myArray[i] < value)
    {
        value = myArray[i];
    }
Console.WriteLine(value);
//4
int[] a = new int[10];
int count = 0;
 
for (int i = 0; i < 10; i++)
{
    Console.Write("a[{0}]=", i);
    a[i] = Convert.ToInt32(Console.ReadLine());
    if ((a[i] % 2) == 0)
        count++;
}
Console.Write(count);
//5
Random rnd = new Random();
int[] B = new int[20]; 
int[] A = new int[20];
int k = 0;
for (int i = 0; i < 20; i++)
{
    A[i] = rnd.Next(-50, 50);
    Console.Write(A[i] + " ");
    if (A[i] > 0)
    {
        B[k] = A[i];
        k++;
    }
}
Console.WriteLine();
for (int i = 0; i < k; i++)
{
    Console.Write(B[i] + " ");
}
Console.ReadKey();
//Последнюю задачу честно вообще не понял, поэтому нарыл какой то инфы в инетренете
//и написал вот это, сегодня буду разбираться с этим заданием



