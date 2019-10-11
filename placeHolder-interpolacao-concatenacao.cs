using System;
using System.Globalization;

namespace Course2
{
    class Program2
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.151245;
            string nome = "Maria";

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));


            /*PLACE HOLDERS*/
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais.", nome, idade, saldo);

            /*INTERPOLAÇÃO*/
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais.");

            /*CONCATENAÇÃO*/
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais.");

            Console.WriteLine("-----------------------");
        }