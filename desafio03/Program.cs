List<int> listaNuns = new List<int>();

void ObterCabecalhoRelatorio(){
    Console.WriteLine();
    Console.WriteLine("****** Relatório ******");
    Console.WriteLine();
}

void ObterMenorNumeroImpar(){
    List<int> listaNumerosImpares = new List<int>();    
    foreach(var listaN in listaNuns )
    {
         if(listaN % 2 != 0)
            listaNumerosImpares.Add(listaN);
    }

    if(listaNumerosImpares.Count > 0){
        int menorImpar = listaNumerosImpares.Min();
        Console.WriteLine($"O menor valor ímpar lido é {menorImpar}");
    }
    else {
        Console.WriteLine("Não existe número ímpar");
    }
}

void ObterMaiorNumeroLido(){

    int maiorValor = listaNuns.Max();
    Console.WriteLine($"O maior valor lido é o {maiorValor}.");

}

void ObterQuantidadeNumerosLidos(){

    int total = listaNuns.Count;
    Console.WriteLine($"Foram lidos {total} número .");

}

void ObterMediaNumerosLidos(){

    int total = listaNuns.Count;
    int soma = listaNuns.Sum();
    float media  = soma / total ;
    Console.WriteLine($"A média dos números lido é {media}.");

}

void ObeterQuantidadeNumero(){

    Dictionary<int, int> counter = new Dictionary<int, int>();


        
    foreach(var inteiros in listaNuns)
    {   
        int valor ;  
        counter.TryGetValue(inteiros, out valor);
        

        if(valor > 0)
        {
            counter.Remove(inteiros);
            
            counter.Add(inteiros,valor +1 );
                  
        }else{
            
            counter.Add(inteiros, +1);
            
        }

    
    }     
    Console.WriteLine("");
    
    foreach(var counters in counter) 
    {
        Console.WriteLine($"o numéro: {counters.Key} aparece {counters.Value} vezes" );
    }

    

}

void LerTeclado(){
   int num ;
    Console.WriteLine("Digite um valor e digite 0 pra saber as estátisticas:");

    do
        {
        num = int.Parse(Console.ReadLine());
      
            if(num !=0 && num >0 ){

            listaNuns.Add(num);    
            }
        }
        while(num !=0 && num > 0 ) ;

        if(listaNuns.Count > 0){
            ObterCabecalhoRelatorio();
            ObterQuantidadeNumerosLidos();
            ObterMaiorNumeroLido();     
            ObterMediaNumerosLidos();
            ObterMenorNumeroImpar();
            ObeterQuantidadeNumero();
        }
        else
        {
            Console.WriteLine("Nenhum número foi lido");
        }

        


}

    LerTeclado();



