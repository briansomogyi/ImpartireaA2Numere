namespace ImpartireaA2Numere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("a="); a=int.Parse(Console.ReadLine());
            Console.Write("b="); b=int.Parse(Console.ReadLine()); 
            if (b == 0) 
            {
                Console.WriteLine("Impartirea nu poate fie efectuata.");
            }
            else 
            {
                if (a % b == 0) 
                {
                    Console.WriteLine(a / b);
                }
                else
                {
                    Console.WriteLine("Impartirea nu poate fi efectuata.");
                }
            }
        }
    }
}