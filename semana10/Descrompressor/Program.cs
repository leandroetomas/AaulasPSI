using System;
using System.IO;
using System.IO.Compression;


namespace Descrompressor
{
    class Program
    {
        static void Main(string[] args)
      {
          string input;
          Console.WriteLine("Seleciona uma opção");
          Console.WriteLine("1 - Comprimir");
          Console.WriteLine("2 - Descomprimir");
          input = Console.ReadLine();
          if (input == "1")
          {
            Comprimir();
            }
          else if (input == "2")
          {
            Descomprimir();
            }
          else
          {
            Console.WriteLine("Opção inválida");
            }
          
      }
      static void Descomprimir(){
        
        string line;

        FileStream fs = new FileStream("ficheiro.txt.gz", FileMode.Open, FileAccess.Read);

        GZipStream gzs = new GZipStream(fs, CompressionMode.Decompress);

        StreamReader sr = new StreamReader(gzs);
        StreamWriter beti = new StreamWriter("ficheiro.txt");

        while ((line = sr.ReadLine()) != null)
        {
            beti.WriteLine(line);
            
            Console.WriteLine(line);
          
        }
       
        beti.Close();

        sr.Close();
        
        
      }
      static void Comprimir(){
        string line;

        FileStream fs = new FileStream("ficheiro.txt.gz", FileMode.Create, FileAccess.Write);

        GZipStream gzs = new GZipStream(fs, CompressionLevel.Optimal);

        StreamWriter sw = new StreamWriter(gzs);

        while ((line = Console.ReadLine()).Length > 0)
        {
            sw.WriteLine(line);
        }

        sw.Close();
       


  

      }
      
        
            
        
    }
}
