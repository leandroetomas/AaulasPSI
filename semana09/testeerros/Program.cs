using System;

namespace testeerros
{
    class Program
    {
        static void Main(string[] args)
      
        {
          Console.Write("Insere um número inteiro: ");
          int i =0;
         
          try{
             i = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine($"Número inserido: {i}");
          }
          catch(FormatException){
            Console.WriteLine("Não é um número inteiro");
          }
          catch(OverflowException){
            Console.WriteLine("O número é muito grande ou muito pequeno");
          }
          catch(Exception e){
            Console.WriteLine("Erro: " + e.Message);
            }
          finally{
            Console.WriteLine("Fim");
          }
          
            
        }
    }
}
