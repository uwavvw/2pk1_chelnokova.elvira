namespace pz_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fact = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int result = 1;
            while (i != fact)
            {
                i++;
                    result *= i;
            }
            Console.WriteLine(result);
        }
    }
}