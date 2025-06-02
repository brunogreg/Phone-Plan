using System;
using System.Globalization;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plano de telefone");
            Console.WriteLine("Neste plano o valor base é: R$ 50,00 por 100 minutos. O que você gastar além desse tempo será cobrado.");

            int tempo;
            double conta = 50.00;
            double excedeu = 0.0;

            tempo = int.Parse(Console.ReadLine()!);

            if (tempo > 100)
            {
                excedeu = tempo - 100;
                conta += excedeu * 2.0;
            }

            Console.WriteLine("O valor da sua conta é: " + conta.ToString("F2", CultureInfo.InvariantCulture));

            if (excedeu > 0)
            {
                Console.WriteLine("Pois você passou " + excedeu.ToString(CultureInfo.InvariantCulture) + " minutos a mais.");
            }

            Console.ReadLine();
        }
    }
}
