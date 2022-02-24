using System;
using System.Collections.Generic;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayNome = new string[3] {"ANA","PAULA","SANTOS"};
            
            Console.WriteLine("=================================");
            int size_String = arrayNome.Length;
            Console.WriteLine("Tamanho do Array: "+size_String);

            if(Array.Exists(arrayNome, e=> e == "ANA")){
                Console.WriteLine("Encontrei 'ANA' no meu Array");
            }

            foreach(string nome in arrayNome){
                Console.Write(" "+nome);
            }
            Console.WriteLine("\n=================================");
//======================================================================================
            var listaNome = new List<string>() {"TIAGO","FERREIRA","MELO"};

            int size_List = listaNome.Count;
            Console.WriteLine("Tamanho do Collection: "+size_List);

            if(listaNome.Exists(e => e == "TIAGO")){
                Console.WriteLine("Encontrei 'Tiago' no meu Collection");
            }

            foreach(string nome1 in listaNome){
                Console.Write(" "+nome1);
            }
            Console.WriteLine("\n=================================");
        }
    }
}
