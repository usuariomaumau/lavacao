namespace lavacao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Exercicio1();

            Exercicio2();

            Exercicio3();

            Exercicio4();
        }

        public static void Exercicio1()
        {
            //exercicio1//*
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Bem-vindo, {nome}!");

            Console.Write("Digite sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Você tem {idade} anos.");

            Console.WriteLine("Muito bom!");
        }

        public static void Exercicio2()
        {
            //exerciocio 2//*


            int num1 = 10;
            int num2 = 20;
            int soma = num1 + num2;

            Console.WriteLine("A soma de {0} e {1} é: {2}", num1, num2, soma);

            Console.WriteLine("digite o primeiro numero");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite o segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());

            soma = num1 + num2;
            Console.WriteLine($"Resultado da soma: {soma}");
        }

        public static void Exercicio3()
        {
            //exercicio3

            Console.WriteLine("digite sua idade");
            int idadeBeber = Convert.ToInt32(Console.ReadLine());

            if (idadeBeber < 18)
            {
                Console.WriteLine("Você é menor de idade");

            }
            else if (idadeBeber > 18) ;
            {
                Console.WriteLine("Você é maior de idade");
            }
        }

        public static void Exercicio4()
        {
            //exercicio 4

            int positivo = 0;

            string teste = "";


            int NEGATIVO = 0;
            int ZERO = 0;
            Console.WriteLine("POSITIVO", 0, "NEGATIVO", 0, "ZERO", 0);

            if (positivo > 0)
            {
                Console.WriteLine("POSITIVO");

            }
            else if (positivo > 18) ;
            {
                Console.WriteLine("Você é maior de idade");
            }
        }
    }

}







