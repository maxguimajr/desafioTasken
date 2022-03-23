
int _num = int.Parse(Console.ReadLine());

imprimeVetor(_num);


void imprimeVetor( int num ){
    Console.WriteLine();

    if(num <= 0){

        Console.WriteLine("Digite um número positivo");

    }

    for(int i = num; i > 0 ; i --)
     {
           for(int j = i; j >= 1 ; j --)
         {
              Console.Write( j * j + " "); 
         }
         Console.WriteLine();
     }  

}