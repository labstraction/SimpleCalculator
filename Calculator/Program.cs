using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeroUnoInStringa = args[0];
            string numeroDueInStringa = args[1];
            int numeroUno = Convert.ToInt32(numeroUnoInStringa);
            int numeroDue = Convert.ToInt32(numeroDueInStringa);
            int somma = numeroUno + numeroDue;
            Console.WriteLine("La somma è: " + somma);

            // Console.WriteLine("La somma è: " + (Convert.ToInt32(args[0]) + Convert.ToInt32(args[1])));
        }
    }
}
