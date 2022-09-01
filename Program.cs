internal class Program
{
    private static void Main(string[] args)
    {
        int sayi = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {   
            Console.WriteLine(sayi + " x " + i + " = " +  sayi*i  );
        }
    }
}