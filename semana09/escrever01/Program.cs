using System;
using System.IO;
namespace escrever01
{
    class Program
    {
        static void Main(string[] args)
        {string input;
          string output="teste.txt";
          string [] linhas;
          int i=0;
          Console.WriteLine("define o tamanho do documento");
          input=Console.ReadLine();
          int n=Convert.ToInt32(input);
          linhas=new string[n];
            Console.WriteLine("escreve algo");
          do
          {
            input = Console.ReadLine();
            linhas[i]= input;
            i++;
          }
          while (input != "" && i<n );
          File.WriteAllLines(output,linhas);
          
          
       }
    }
}
