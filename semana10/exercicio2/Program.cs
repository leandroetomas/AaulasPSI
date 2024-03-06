using System;

namespace exercicio2
{
    class Program
    {
        static void EscreverTexto(string[] args)
        {
            string line;

            FileStream fs = File.Create(“dados.txt”);
            fs.writeLine("EscreverTexto");
            fs.WriteLine(34);
            fs.WriteLine(3.14);
            fs.Close();
          
              
            }

      static void LerTexto(string[] args){
        string line;
        FileStream fs = File.Open(“dados.txt”, FileMode.Open);
       Console.WriteLine(fs.ReadLine());
        
       
        fs.Close();
        
      }

       static void LerBin(string[] args){


        string line;
        FileStream fs = File.Open(“dados.bin”, FileMode.Open);
        fs.WriteLine(fs.());
        fs.Close();
         
       }
          string line;
      
          FileStream fs = File.Create(“dados.txt”);
          fs.writeLine("LerTexto");
          fs.WriteLine(45);
          fs.WriteLine(3.23);
          fs.Close();

        
          
    
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
