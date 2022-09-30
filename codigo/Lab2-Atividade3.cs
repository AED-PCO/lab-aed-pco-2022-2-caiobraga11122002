namespace ConsoleApp5
{
    internal class Program
    {
        static int ElevevadoRecursivo(int A, int B)
        {
            if ((B == 1 || A == 1))
            {
                return A;
            }
            return A * ElevevadoRecursivo(A, B - 1);
        }
        static void Main(string[] args)
        {
            int A, B, total;
            Console.WriteLine("Qual o valor de A: ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor de B: ");
            B = int.Parse(Console.ReadLine());

            total = ElevevadoRecursivo(A, B);

            Console.WriteLine(total);

            Console.ReadKey();
        }
    }
}
