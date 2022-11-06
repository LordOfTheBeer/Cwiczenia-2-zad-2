namespace ROK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rok");
            Decimal rok = decimal.Parse(Console.ReadLine()!);

            if ((rok % 4 == 0) & (rok % 100 != 0))
                Console.WriteLine(" Rok przestepny ");

            else if (rok % 400 == 0)
                Console.WriteLine(" Rok przestepny ");

            else
                Console.WriteLine(" Rok nie jest przestepny ");
        }
    }
}