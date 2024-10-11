using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)    // Função principal.
        {
            Menu();
        }

        static void Menu()    // Menu de seleção para operações matemáticas.
        {
            Console.Clear();

            Console.WriteLine("-=-=-=-=-=-=-=-=- Calculadora Simples -=-=-=-=-=-=-=-=-");
            Console.WriteLine("");

            Console.WriteLine("---------------------------");
            Console.WriteLine("| [1] -> Soma             |");
            Console.WriteLine("| [2] -> Subtração        |");
            Console.WriteLine("| [3] -> Divisão          |");
            Console.WriteLine("| [4] -> Multiplicação    |");
            Console.WriteLine("| [5] -> Raiz Quadrada    |");
            Console.WriteLine("| [6] -> Fechar Programa  |");
            Console.WriteLine("---------------------------");

            Console.WriteLine("");

            Console.Write("Digite a operação que deseja realizar: ");
            string Selecao = Console.ReadLine();

            switch (Selecao)
            {
                case "1": Soma(); break;
                case "2": Subtracao(); break;
                case "3": Divisao(); break;
                case "4": Multiplicacao(); break;
                case "5": RaizQuadrada(); break;
                case "6": Sair(); break;
                default: CaractereInvalido(); break;
            }
        }

        static void Soma()    // Função para realizar a soma.
        {
            Console.Clear();

            try
            {
                Console.WriteLine("-=-=-=-=-=-=-=-=- Modulo de Soma -=-=-=-=-=-=-=-=-");
                Console.WriteLine("");

                Console.Write("Digite o primeiro valor: ");
                double PrimeiroValor = Double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo valor: ");
                double SegundoValor = Double.Parse(Console.ReadLine());

                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"O resultado da soma entre {PrimeiroValor} + {SegundoValor} é: {PrimeiroValor + SegundoValor}");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("");
            }

            catch (FormatException ex)
            {
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"Você Digitou um caractere invlido! {ex.Message}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("");
            }

            catch (Exception ex)
            {
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"Ocorreu um pequeno erro...! {ex.Message}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("");
            }

            finally
            {
                Console.WriteLine("Digite [1] para fazer outra Soma, ou [0] para voltar ao meu: ");
                string Continuar = Console.ReadLine();

                switch (Continuar)
                {
                    case "1": Soma(); break;
                    case "0": Menu(); break;
                    default: CaractereInvalido(); break;
                }
            }
        }

        static void Subtracao()    // Função para realizar subtração
        {
            Console.Clear();

            try
            {
                Console.WriteLine("-=-=-=-=-=-=-=-=- Modulo de Subtração -=-=-=-=-=-=-=-=-");
                Console.WriteLine("");

                Console.Write("Digite o primeiro valor: ");
                double PrimeiroValor = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo valor: ");
                double SegundoValor = double.Parse(Console.ReadLine());

                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"O resultado da subtração entre {PrimeiroValor} - {SegundoValor} é: {PrimeiroValor - SegundoValor}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("");
            }

            catch (FormatException ex)
            {
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"Você Digitou um caractere invlido! {ex.Message}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("");
            }

            catch (Exception ex)
            {
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"Ocorreu um pequeno erro...! {ex.Message}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("");
            }

            finally
            {
                Console.WriteLine("Digite [1] para fazer outra Subtração, ou [0] para voltar ao meu: ");
                string Continuar = Console.ReadLine();

                switch (Continuar)
                {
                    case "1": Subtracao(); break;
                    case "0": Menu(); break;
                    default: CaractereInvalido(); break;
                }
            }
        }

        static void Divisao()    // Função para realizar Divisão
        {
            Console.Clear();

            try
            {
                Console.WriteLine("-=-=-=-=-=-=-=-=- Modulo de Divisão -=-=-=-=-=-=-=-=-");
                Console.WriteLine("");

                Console.Write("Digite o primeiro Número: ");
                float PrimeiroValor = float.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                float SegundoNumero = float.Parse(Console.ReadLine());

                if (SegundoNumero == 0)
                {
                    throw new DivideByZeroException();
                }

                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"O resultado da divisão entre {PrimeiroValor} / {SegundoNumero} = {(PrimeiroValor / SegundoNumero):F2}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("");
            }

            catch (FormatException ex)
            {
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"Você Digitou um caractere invlido! {ex.Message}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("");
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"Não se pode se dividir por 0 (ZERO)! {ex.Message}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("");
            }

            finally
            {
                Console.WriteLine("Digite [1] para fazer outra Divisão, ou [0] para voltar ao meu: ");
                string Continuar = Console.ReadLine();

                switch (Continuar)
                {
                    case "1": Divisao(); break;
                    case "0": Menu(); break;
                    default: CaractereInvalido(); break;
                }
            }
        }

        static void Multiplicacao()    // Função para realizar Multiplicação
        {
            Console.Clear();

            try
            {
                Console.WriteLine("-=-=-=-=-=-=-=-=- Modulo de Multiplicação -=-=-=-=-=-=-=-=-");
                Console.WriteLine("");

                Console.Write("Digite o primerio número: ");
                double PrimeiroNumero = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                double SegundoValor = double.Parse(Console.ReadLine());

                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"O resultado da Multiplicação entre {PrimeiroNumero} * {SegundoValor} = {PrimeiroNumero * SegundoValor}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("");
            }

            catch (FormatException ex)
            {
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"Você Digitou um caractere invlido! {ex.Message}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("");
            }

            catch (Exception ex)
            {
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"Ocorreu um pequeno erro...! {ex.Message}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("");
            }

            finally
            {
                Console.WriteLine("Digite [1] para fazer outra Multiplicação, ou [0] para voltar ao meu: ");
                string Continuar = Console.ReadLine();

                switch (Continuar)
                {
                    case "1": Multiplicacao(); break;
                    case "0": Menu(); break;
                    default: CaractereInvalido(); break;
                }
            }
        }

        static void RaizQuadrada()
        {
            Console.Clear();

            try
            {
                Console.WriteLine("-=-=-=-=-=-=-=-=- Modulo de Raiz Quadrada -=-=-=-=-=-=-=-=-");
                Console.WriteLine("");

                Console.Write("Digite o número que deseja decobrir a Raiz: ");
                double PrimeiroNumero = double.Parse(Console.ReadLine());

                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"A Raiz Quadrada de {PrimeiroNumero} = {Math.Sqrt(PrimeiroNumero):F2}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("");
            }

            catch (FormatException ex)
            {
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"Você Digitou um caractere invlido! {ex.Message}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("");
            }

            catch (Exception ex)
            {
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"Ocorreu um pequeno erro...! {ex.Message}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("");
            }

            finally
            {
                Console.WriteLine("Digite [1] para fazer outra Multiplicação, ou [0] para voltar ao meu: ");
                string Continuar = Console.ReadLine();

                switch (Continuar)
                {
                    case "1": RaizQuadrada(); break;
                    case "0": Menu(); break;
                    default: CaractereInvalido(); break;
                }
            }
        }

        static void Sair()
        {
            Console.WriteLine("");

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Encerrando a Calculadora!");
            Console.WriteLine("Obrigado por testar!");
            Console.WriteLine("--------------------------------");

            Console.ReadKey();

            System.Environment.Exit(0);
        }

        static void CaractereInvalido()
        {
            Console.WriteLine("");

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Digite um valor valido!");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu");
            Console.WriteLine("-----------------------------------------");

            Console.ReadKey();
            Console.Clear();

            Menu();
        }
    }
}
