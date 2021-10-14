using System;

namespace caculadora_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            int operacao;
            double n1;
            double n2;
            double resultado;
            bool validacao = true;
            Program program = new Program(); // criar uma variável que chama a função que foi delcarada fora do Main

            Console.WriteLine("####### SEJAM BEM VINDOS - CALCULADORA DOTNET ####");

            do
            {
                
                Console.WriteLine("Qual a operação desejada? ");
                Console.WriteLine("(1) - Soma");
                Console.WriteLine("(2) - Subtração");
                Console.WriteLine("(3) - Multiplicação");
                Console.WriteLine("(4) - Divisão");
                Console.WriteLine("(5) - Sair");

                Console.WriteLine("Digite sua opção: ");
                operacao = Convert.ToInt32(Console.ReadLine());

                switch (operacao)
                {

                    case 1:
                        Console.WriteLine("Digite o primeiro número: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número: ");
                        n2 = Convert.ToDouble(Console.ReadLine());

                        resultado = program.Soma(n1, n2);
                        Console.WriteLine("Resultado: " + resultado);
                        
                        
                        break;

                    case 2:
                        Console.WriteLine("Digite o primeiro número: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número:  ");
                        n2 = Convert.ToDouble(Console.ReadLine());

                        resultado = program.Sub(n1, n2);
                        Console.WriteLine("Resultado: " + resultado);
                        
                        break;

                    case 3:
                        Console.WriteLine("Digite o primeiro número: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número: ");
                        n2 = Convert.ToDouble(Console.ReadLine());

                        resultado = program.Mult(n1, n2);
                        Console.WriteLine("Resultado: " + resultado);
                      
                        break;

                    case 4:
                        Console.WriteLine("Digite o primeiro número: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número: ");
                        n2 = Convert.ToDouble(Console.ReadLine());

                        resultado = program.Div(n1, n2);
                        Console.WriteLine("Resultado: " + resultado);
                        break;

                    case 5:
                        validacao = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida!!");
                        break;
                }

                Console.WriteLine("Pressione Enter para reinciar");
                Console.ReadLine();
                Console.Clear();

            } while (validacao);
            
            
        }

        

        public double Soma(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Sub(double n1, double n2)
        {
            return n1 - n2;
        }

        public double Mult(double n1, double n2)
        {
            return n1 * n2;
        }

        public double Div(double n1, double n2)
        {
            return n1 / n2;
        }
    }
}
