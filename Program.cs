using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz Csharp, Hoşgeldiniz!";
            string degisken2 = "Csharp";

            //Length
            Console.WriteLine(degisken.Length); 
            
            // ToUpper ToLower

            Console.WriteLine(degisken.ToLower());
            Console.WriteLine(degisken.ToUpper());

            //Concat   
            Console.WriteLine(String.Concat(degisken,"Merhaba"));

            //Compare CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2));//0,1,-1
            Console.WriteLine(String.Compare(degisken,degisken2,true));
            Console.WriteLine(String.Compare(degisken, degisken2, false));

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba"));

            //IndexOf

            Console.WriteLine(degisken.IndexOf("Cs"));
            Console.WriteLine(degisken.IndexOf("Zikriye"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba"));

            //PadLeft-PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50)+ degisken2);
            Console.WriteLine(degisken.PadRight(50,'-') + degisken2);

            //Remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            //Replace
            Console.WriteLine(degisken.Replace("Csharp","C#"));
            Console.WriteLine(degisken.Replace(" ","*"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);

        }
    }
}
