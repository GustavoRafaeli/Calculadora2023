using Calculadora.ConsoleApp.Entities;

namespace Calculadora.ConsoleApp

{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("(1) para somar;");
                Console.WriteLine("(2) para subtrair;");
                Console.WriteLine("(3) para multiplicar;");
                Console.WriteLine("(4) para dividir;");
                Console.WriteLine("(S) para sair;");

                String option = Console.ReadLine();

                if (option.ToUpper() == "S")
                {
                    break;
                }

                if (option != "1" && option != "2" && option != "3" && option != "4" && option != "S")
                {
                    Console.WriteLine("Operação Inválida, tente novamente.....");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Digite o primeiro valor:");
                double valor1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor:");
                double valor2 = double.Parse(Console.ReadLine());

                Calculo calculo = new Calculo(valor1, valor2);

                switch (option.ToUpper())
                {
                    case "1":
                        calculo.Soma();
                        Console.WriteLine("O resultado é: " + calculo.Resultado.ToString("N2"));
                        Console.WriteLine();
                        break;

                    case "2":
                        calculo.Sub();
                        Console.WriteLine("O resultado é: " + calculo.Resultado.ToString("N2"));
                        Console.WriteLine();
                        break;
                    case "3":
                        calculo.Mult();
                        Console.WriteLine("O resultado é: " + calculo.Resultado.ToString("N2"));
                        Console.WriteLine();
                        break;

                    case "4":
                        {
                            while (valor2 == 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Não pode dividir por 0, Digite novamente.");
                                Console.WriteLine();

                                Console.WriteLine("Digite o primeiro valor:");
                                valor1 = double.Parse(Console.ReadLine());
                                Console.WriteLine("Digite o segundo valor:");
                                valor2 = double.Parse(Console.ReadLine());

                                calculo = new Calculo(valor1, valor2);

                            }

                            Console.WriteLine();
                            calculo.Div();
                            Console.WriteLine("O resultado é: " + calculo.Resultado.ToString("N2"));
                            Console.WriteLine();
                        }
                        break;

                        Console.ReadLine();
                        Console.Clear();
                }

            }

        }
    }
}