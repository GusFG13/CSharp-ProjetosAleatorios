using System.Linq;

namespace ConsoleApp1
{
    internal class IntMaisFreqEmVetor
    {
        static void Main(string[] args)
        {
            int x;
            int maiorFreq;
            bool achouUm = false;
            string resposta = "";
            Dictionary<int, int> dicValores = new Dictionary<int, int>();

            do
            {
                Console.Write($"Informe quantos elementos tem o vetor: ");
            } while (!int.TryParse(Console.ReadLine(), out x));

            int[] arrX = new int[x];

            for (int i = 0; i < x; i++)
            {
                do
                {
                    Console.WriteLine($"Digite o {i + 1}o. elemento");
                } while (!int.TryParse(Console.ReadLine(), out arrX[i]));
            }

            foreach (int i in arrX)
            {
                if (dicValores.ContainsKey(i))
                {
                    dicValores[i]++;
                }
                else
                {
                    dicValores.Add(i, 1);
                }
            }

            maiorFreq = dicValores.Values.Max();

            foreach ((int chave, int valor) in dicValores)
            {
                if (valor == maiorFreq) {
                    
                    if (achouUm) //caso mais de um número tenha a mesma freq
                    {
                        resposta = resposta + "; " + chave.ToString();
                    }
                    else
                    {
                        resposta = chave.ToString();
                        achouUm = true;
                    }  
                }
            }

            if (resposta.Length == 1)
            {
                Console.WriteLine($"O No. mais frequente é {resposta} com {maiorFreq} ocorrências.");
            } 
            else
            {
                Console.WriteLine($"Os Nos. mais frequentes são ({resposta}) com {maiorFreq} ocorrências.");
            }
        }
    }
}