// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite uma palavra para ser compactada: ");
Console.WriteLine("");

string palavra = Console.ReadLine();
 
 contaLetra(palavra);
 
static void contaLetra(string palavra)
        {

            string novaPalavra = "";
            string letra = "";
            int conta = 0;

            for (int i = 0; i < palavra.Length; i++)
            {

                if (letra == palavra.Substring(i, 1))
                {
                    conta++;
                }
                else
                {
                    if (conta == 0) novaPalavra = novaPalavra + letra;
                    if (conta > 0)
                    {
                        conta++;
                        novaPalavra = novaPalavra + letra + conta;
                    }
                    conta = 0;
                }
                letra = palavra.Substring(i, 1);
            }

            if (conta == 0) novaPalavra = novaPalavra + letra;
            if (conta > 0)
            {
                conta++;
                novaPalavra = novaPalavra + letra + conta;
            }

           Console.WriteLine("A palavra compactada é" + novaPalavra);
        }