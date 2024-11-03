using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedraPapelTesoura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seuContador = 0;
            int adContador = 0;

            while (true)
            {
                Random random = new Random();

                int numAdversario = random.Next(1, 3);

                int seuNum;
                Console.Clear();

                Console.WriteLine("Joguinho do Pedra, Papel e Tesoura");
                Console.WriteLine("1 - Para Pedra");
                Console.WriteLine("2 - Para Papel");
                Console.WriteLine("3 - Para Tesoura");
                Console.Write("Digite sua Opção: ");

                seuNum = int.Parse(Console.ReadLine());
                string suaArma = EscolherArma(seuNum);
                string AdArma = EscolherArma(numAdversario);

                Console.Clear();
                Console.WriteLine($"Você escolheu {suaArma} e seu adversário escolheu {AdArma}\n");
                int result = QuemVenceu(suaArma, AdArma);

                switch (result)
                {
                    case 0:
                        Console.WriteLine($"Empate!\nPlacar: {seuContador}X{adContador}");
                        break;
                    case 1:
                        seuContador++;
                        Console.WriteLine($"Você venceu!\nPlacar: {seuContador}X{adContador}");
                        break;
                    case 2:
                        adContador++;
                        Console.WriteLine($"Seu Adversário venceu!\nPlacar: {seuContador}X{adContador}");
                        break;
                }
                Console.WriteLine("Deseja Jogar Novamente? (s/n)");
                if (Console.ReadLine().ToLower() != "s") { break; }
                Console.Clear();
            }
        }
        static string EscolherArma(int num)
        {
            string arma;

            switch (num)
            {
                case 1:
                    arma = "Pedra";
                    break;
                case 2:
                    arma = "Papel";
                    break;
                case 3:
                    arma = "Tesoura";
                    break;
                default:
                    arma = null;
                    break;
            }
            return arma;
        }
        static int QuemVenceu(string seu, string ad)
        {
            if (seu == "Pedra" && ad == "Tesoura" || seu == "Papel" && ad == "Pedra" || seu == "Tesoura" && ad == "Papel")
            {
                //Você venceu
                return 1;
            }
            else if (ad == "Pedra" && seu == "Tesoura" || ad == "Papel" && seu == "Pedra" || ad == "Tesoura" && seu == "Papel")
            {
                //Seu Adversário venceu
                return 2;
            }
            else
            {
                //Empate
                return 0;
            }
        }
    }
}
