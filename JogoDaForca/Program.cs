using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca
{
    internal class Program
    {
        static string[] ListaDePalavras = {"ABACATE","ABACAXI", "ACEROLA", "AÇAI", "ARAÇA", "BACABA", "BACURI", "BANANA",
            "CAJA", "CAJU", "CARAMBOLA", "CUPUAÇU", "GRAVIOLA", "GOIABA", "JABUTICABA", "JENIPAPO","MAÇA", "MANGABA",
            "MANGA", "MARACUJA", "MURICI", "PEQUI", "PITANGA", "PITAYA", "SAPOTI", "TANGERINA", "UMBU", "UVA", "UVAIA" };

        static Random geradorAleatoria = new Random();
        static int Posicao = geradorAleatoria.Next(ListaDePalavras.Length);
        static string palavraAleatoria = ListaDePalavras[Posicao];
        static char[] palavraEncontrada = new char[palavraAleatoria.Length];
        static int chances = 0;

        static void Main(string[] args)
        {
            CaracteresPalavraSecreta();

            MenuJogo();

            while (chances != 5)
            {
                DesenhoDaForca();
                VerificacaoDoCaracterComResposta();
                VerificacaoParaPerder();
                VerificacaoParaGanhar();
            }
        }

        static void VerificacaoParaGanhar()
        {
            var exist = palavraEncontrada.Contains('_');

            if (!exist)
            {
                Console.WriteLine(" ");
                Console.WriteLine(palavraEncontrada);
                Console.WriteLine("Você ganhou! Fim de jogo");
                Console.ReadKey();
                Environment.Exit(5);
            }
        }

        static void VerificacaoParaPerder()
        {
            if (chances == 5)
            {
                Console.Clear();
                DesenhoDaForca5();

                Console.WriteLine($"A palavra era: {palavraAleatoria}\n");
                Console.WriteLine("Suas chances acabaram! Fim de jogo!");
                Console.ReadKey();
            }
        }

        static void VerificacaoDoCaracterComResposta()
        {
            Console.Write("\n\nQual é o seu chute? ");
            char resposta = Convert.ToChar(Console.ReadLine().ToUpper());

            if (!palavraAleatoria.Contains(resposta))
            {
                chances++;
            }
            else
            {
                for (int i = 0; i < palavraAleatoria.Length; i++)
                {
                    if (resposta == palavraAleatoria[i])
                    {
                        palavraEncontrada[i] = resposta;
                    }
                }
            }
        }

        static void MenuJogo()
        {
            Console.WriteLine("- Bem-vindo(a) ao jogo da forca -\n\nTema: Frutas\n");
            Console.WriteLine("Você terá 5 chances para acertar a palavra! Bom jogo.");
            Console.WriteLine("\nPressione qualquer tecla para começar o jogo!");
            Console.ReadKey();
        }

        static void DesenhoDaForca()
        {
            if (chances == 0)
            {
                DesenhoDaForca0();
            }
            else if (chances == 1)
            {
                DesenhoDaForca1();
            }
            else if (chances == 2)
            {
                DesenhoDaForca2();
            }
            else if (chances == 3)
            {
                DesenhoDaForca3();
            }
            else if (chances == 4)
            {
                DesenhoDaForca4();
            }
        }

        static void CaracteresPalavraSecreta()
        {
            for (int i = 0; i < palavraAleatoria.Length; i++)
            {
                palavraEncontrada[i] = '_';
            }
        }

        static void DesenhoDaForca0()
        {
            Console.Clear();

            Console.WriteLine("-------------");
            Console.WriteLine("  |/        |");
            Console.WriteLine("  |         |");
            Console.WriteLine("  |          ");
            Console.WriteLine("  |          ");
            Console.WriteLine("  |          ");
            Console.WriteLine("  |          ");
            Console.WriteLine("  |          ");
            Console.WriteLine(" _|____");
            Console.WriteLine("\n\n");

            Console.WriteLine(palavraEncontrada);
        }

        static void DesenhoDaForca1()
        {
            Console.Clear();
            Console.WriteLine("-------------");
            Console.WriteLine("  |/        |");
            Console.WriteLine("  |         |");
            Console.WriteLine("  |         o");
            Console.WriteLine("  |          ");
            Console.WriteLine("  |          ");
            Console.WriteLine("  |          ");
            Console.WriteLine("  |          ");
            Console.WriteLine(" _|____");

            Console.WriteLine("\n\nVocê errou!\n");

            Console.WriteLine(palavraEncontrada);

        }

        static void DesenhoDaForca2()
        {
            Console.Clear();
            Console.WriteLine("-------------");
            Console.WriteLine("  |/        |");
            Console.WriteLine("  |         |");
            Console.WriteLine("  |         o");
            Console.WriteLine("  |        / ");
            Console.WriteLine("  |          ");
            Console.WriteLine("  |          ");
            Console.WriteLine("  |          ");
            Console.WriteLine(" _|____");

            Console.WriteLine("\n\nVocê errou!\n");

            Console.WriteLine(palavraEncontrada);
        }

        static void DesenhoDaForca3()
        {
            Console.Clear();
            Console.WriteLine("-------------");
            Console.WriteLine("  |/        |");
            Console.WriteLine("  |         |");
            Console.WriteLine("  |         o");
            Console.WriteLine("  |        / \\");
            Console.WriteLine("  |          ");
            Console.WriteLine("  |          ");
            Console.WriteLine("  |          ");
            Console.WriteLine(" _|____");

            Console.WriteLine("\n\nVocê errou!\n");

            Console.WriteLine(palavraEncontrada);
        }

        static void DesenhoDaForca4()
        {
            Console.Clear();
            Console.WriteLine("-------------");
            Console.WriteLine("  |/        |");
            Console.WriteLine("  |         |");
            Console.WriteLine("  |         o");
            Console.WriteLine("  |        /x\\");
            Console.WriteLine("  |          ");
            Console.WriteLine("  |          ");
            Console.WriteLine("  |          ");
            Console.WriteLine(" _|____");

            Console.WriteLine("\n\nVocê errou!\n");

            Console.WriteLine(palavraEncontrada);
        }

        static void DesenhoDaForca5()
        {
            Console.Clear();
            Console.WriteLine("-------------");
            Console.WriteLine("  |/        |");
            Console.WriteLine("  |         |");
            Console.WriteLine("  |         o");
            Console.WriteLine("  |        /x\\");
            Console.WriteLine("  |         x");
            Console.WriteLine("  |          ");
            Console.WriteLine("  |          ");
            Console.WriteLine(" _|____");

            Console.WriteLine("\n\n");
        }
    }
}
