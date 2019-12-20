using System;

namespace CompitoVacanze
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            //viene stampato il numero massimo che un int può contenere 
            Console.WriteLine(a);
            if (a == 214783647)
            {
                //il programmma va in overflow perchè viene aggiunto un 1 al numero massimo che l'int può contenere 
                Console.WriteLine(a + 1);
            }
            int b = 128;
            int c = -b;
            Console.WriteLine(Convert.ToString(b, 2));
            Console.WriteLine(Convert.ToString(c, 2));
            //in queste 4 righe l'int c viene convertito in binario e poi stampato
            int value = 31;
            int somma = value;
            value = ~value + 1; // NOT 
            //value = value + 1;
            somma = somma + value;
            Console.WriteLine($"{value} e {somma}");
            long number = 55555;
            Console.WriteLine(Convert.ToString(number, 2));
            short number1 = (short)number;
            Console.WriteLine(number1); 
        }
    }
}
