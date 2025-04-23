namespace lavacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercicio1//*
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Bem-vindo, {nome}!");

            Console.Write("Digite sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Você tem {idade} anos.");


            Console.WriteLine("Muito bom!");

            //exerciocio 2//*

            {
                static void Main()
                {
                    int num1 = 10;
                    int num2 = 20;
                    int soma = num1 + num2;

                    Console.WriteLine("A soma de {0} e {1} é: {2}", num1, num2, soma);
                }
                Console.WriteLine("digite o primeiro numero");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("digite o segundo numero");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int soma = num1 + num2;
                Console.WriteLine($"Resultado da soma: {soma}");

                //exercicio3

                Console.WriteLine("digite sua idade");
                int idadeBeber = Convert.ToInt32(Console.ReadLine());

                if (idade < 18)
                {
                    Console.WriteLine("Você é menor de idade");

                }
                else if (idade > 18);
                {
                    Console.WriteLine("Você é maior de idade");
                }
                //exercicio 4

                int POSITIVO > 0;
                int NEGATIVO < 0;
                int ZERO = 0;
                Console.WriteLine("POSITIVO", 0, "NEGATIVO", 0, "ZERO", 0);
               
                if (positivo > 0)
                {
                    Console.WriteLine("POSITIVO");

                }
                else if (POSITIVO > 18);
                {
                    Console.WriteLine("Você é maior de idade");
                }
            }

        }
    }
}
                 

      
    



