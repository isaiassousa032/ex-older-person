using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args) {

            Pessoa Pessoa1 = new Pessoa();
            Pessoa Pessoa2 = new Pessoa();

            Console.WriteLine("Dados da Primeira Pessoa:");
            Console.Write("Nome: ");
            Pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            Pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            Pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            Pessoa2.Idade = int.Parse(Console.ReadLine());

            if(Pessoa1.Idade > Pessoa2.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {Pessoa1.Nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {Pessoa2.Nome}");
            }
        }
    }
}
