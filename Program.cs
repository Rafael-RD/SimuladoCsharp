using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            void forca()
            {
                string gerarPalavra()
                {
                    string[] palavras = new string[] {
                        "abacate", "abacaxi", "abelha", "abanador", "antologia", "amor", "aba", "abrigo", "abrir",
                        "banana", "boi", "batata", "bacalhau", "bexiga", "bowl", "batedeira", "bisturi", "barreira",
                        "banco", "caixa", "chantilly", "cachorro", "cuidado", "caneta", "carinho", "cabra", "cesto",
                        "dados", "dizer", "danone", "dente", "diamante", "diafragma", "detonar", "dia","elefante",
                        "esmeralda", "esfinge", "esfera", "encontro", "ema", "escola", "economia","formiga", "fama",
                        "festa", "fiador", "ferver", "flauta", "figo", "fiapo", "fotografia","goiaba", "gelo", "grito",
                        "guria", "goleiro", "golfinho", "golfe", "girar","harmonia", "haste", "hectare", "hepatite",
                        "hiena", "hidrante","igreja", "importante", "idoso", "irado", "identidade", "idioma", "idade",
                        "idiota","jantar", "jumento", "jararaca", "janela", "jerimum", "jaula", "jabuti", "jaleco",
                        "laranja", "lua", "luz", "lindo", "lacraia", "lactose", "lacrar","manga", "morango", "mico",
                        "matar", "mingau", "moqueca", "mocassin","nectarina", "nada", "navio", "namorado", "ninja",
                        "natal", "narciso", "narina", "nabo","ovo", "ostra", "obstetra", "orangotango", "olhar", "ortodoxo",
                        "ouro", "ornamento","pato", "polvo", "povoar", "pano", "princesa", "pizza", "patroa","queijo",
                        "quitanda", "quinta", "quantia", "quarentena", "quadrilha", "quaresma", "quartzo", "quebrar",
                        "risada", "rio", "remar", "rato", "racional", "rainha", "radioatividade", "raiz", "raiva", "rachadura",
                        "salada", "salamandra", "sacola", "siri", "sabre", "sucarose", "sabedoria", "sacerdote","tatu",
                        "tabacaria", "taberneiro", "torrada", "tamanho", "tatuagem", "trem","uva", "universo", "unanimidade",
                        "ubuntu", "universidade", "urso", "uivar", "unir","vela", "valeta", "vacilo", "valor", "vagem",
                        "vadiagem", "vaca", "valentia", "vidro", "valsa","xadrez", "xilofone", "xarope", "xenofobia", "xereta",
                        "xerife", "xaveco", "xixi", "xale","zebra", "zagueiro", "zero", "zoeira", "zepelim", "zinco", "zumbido"};

                    return palavras[random.Next(0, palavras.Length)];
                }

                Console.WriteLine("Jogo da forca\nTente adivinhar a palavra!");
                string resposta = gerarPalavra();
                char[] palavra = new char[resposta.Length];
                int tentativas = 0;
                for (int i = 0; i < resposta.Length; i++)
                {
                    palavra[i] = '_';
                }
                while (palavra.Contains('_'))
                {
                    Console.WriteLine(palavra);
                    Console.Write("Digite uma letra para jogar: ");
                    string chute = Console.ReadLine();
                    if (resposta.Contains(chute[0]))
                    {
                        List<int> idxAcertos = new List<int>();
                        for (int i = 0; i < resposta.Length; i++)
                        {
                            if (chute[0] == resposta[i]) idxAcertos.Add(i);
                        }
                        for (int i = 0; i < idxAcertos.Count; i++)
                        {
                            palavra[idxAcertos[i]] = resposta[idxAcertos[i]];
                        }
                    }
                    tentativas++;
                }
                Console.WriteLine($"\nParabens você ganhou em {tentativas} tentativas");
            }

            void palindromo()
            {
                Console.Write("Palindromo\nDigite uma palavra: ");
                string palavra = Console.ReadLine();
                bool flag = true;
                for (int i = 0; i < palavra.Length / 2; i++)
                {
                    if (palavra[i] != palavra[palavra.Length - i - 1]) flag = false;
                }
                if (flag) Console.WriteLine($"A palavra {palavra} é um palindromo");
                else Console.WriteLine($"A palavra {palavra} não é um palindromo");
            }

            void ordenar()
            {
                Console.WriteLine("Ordenar numeros");
                Console.Write("Quantos numeros serão digitados: ");
                int qtd = int.Parse(Console.ReadLine());
                int[] array = new int[qtd];
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"Numero para a posição {i + 1}: ");
                    array[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                for (int i = 0; i < array.Length; i++)
                {
                    int idxMenor = i;
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[idxMenor] > array[j]) idxMenor = j;
                    }
                    (array[i], array[idxMenor]) = (array[idxMenor], array[i]);
                }
                Console.WriteLine("\nOrdenado:");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }

            }

            ReAsk:
            Console.WriteLine("1 - Forca");
            Console.WriteLine("2 - Palindromo");
            Console.WriteLine("3 - Ordenar");
            Console.Write("Selecione um programa: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine();
                    forca();
                    break;
                case "2":
                    Console.WriteLine();
                    palindromo(); 
                    break;
                case "3":
                    Console.WriteLine();
                    ordenar();
                    break;
                default:
                    goto ReAsk;
            }
        }
    }
}
