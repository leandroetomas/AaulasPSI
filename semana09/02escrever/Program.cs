using System;
using System.IO;
namespace _02escrever
{
    class Program
    {
        static void Main(string[] args)
        {
          string input;
          string output="teste.txt";
          StreamWriter sw = new StreamWriter(output);

          
            Console.WriteLine("escreve algo");
          do
          {
            input = Console.ReadLine();
            
            sw.WriteLine(input);
          
            
          }
          while (input != ""  );
          sw.Close();
          
        }
    }
}
