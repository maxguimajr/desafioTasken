/*estou deixando um arquivo .txt como exemplo na raiz do projeto, caso queira
exibir o arquivo só digitar "max.txt" no console.
*/

Console.WriteLine("Digite o caminho do arquivo: ");

Console.WriteLine("");

string caminho = Console.ReadLine();
var linha = File.ReadAllLines(caminho);

    int tamanhoLinha = linha.Length;

    if(tamanhoLinha > 0)
    {   
        List<int> listVogais = new List<int>();
        List<int> listConsoantes = new List<int>();


        for(int indexLinha = 0; indexLinha < tamanhoLinha ;indexLinha++)
        {
            int vogais = 0 ;
            int consoantes = 0 ;

            var letra = linha[indexLinha].ToCharArray();
            int tamanho = letra.Length;

             for(int indexLetra = 0; indexLetra <= tamanho -1; indexLetra++ )
             {
                 var resultado = validaLetras(letra[indexLetra]);
                
                 if(resultado == 0)
                 {
                     consoantes ++;
                 }
                 else if(resultado == 1)
                 {
                     vogais ++;
                 }
             }
    
             listVogais.Add(vogais);
             listConsoantes.Add(consoantes);            
        }
            Console.WriteLine("");
    
         var resultVogais = listVogais.IndexOf(listVogais.Max());
         var resultConsoantes = listConsoantes.IndexOf(listConsoantes.Max());

    
         Console.WriteLine( $"A linha com maior número de vagais é a linha : {resultVogais+1}" );
         Console.WriteLine( $"A linha com maior número de consoantes é a linha : {resultConsoantes+1}" );
        
    }
    else
        Console.WriteLine("selecione uma texto válido");

int validaLetras( char letra ){ //0 - consoante | 1- vogal | 2- descarta
        
        var vogal = "aeiou";
        var consoante = "bcdfghjklmnpqrstvwyxz";
        
        if(vogal.Contains(letra.ToString().ToLower())){
            return 1;
        }
        else if(consoante.Contains(letra.ToString().ToLower())){
            return 0;
        }
        else
            return 2;
    }

  


