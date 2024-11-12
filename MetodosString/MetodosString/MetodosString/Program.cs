using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "   abcde FGHIJ ABC abc DEFG  ";

            //Para Caps
            string s1 = original.ToUpper();
            //Sem o Caps
            string s2 = original.ToLower();
            //Remove Espaço em branco
            string s3 = original.Trim();

            //Index do primeiro elemento passado para o método
            int n1 = original.IndexOf("bc");
            //Index do último elemento passado para o método
            int n2 = original.LastIndexOf("bc");

            //Recorta a String no index passado para o método
            string s4 = original.Substring(3);

            //Recorta a String no index passado para o método
            string s5 = original.Substring(3, 5);

            //Substitui o caracter da esquerda pelo da direita
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");

            //Verifica se a string é nula
            bool b1 = String.IsNullOrEmpty(original);

            //Verifica se a string é nula ou espaco em branco
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("\nToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("\nIndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("\nSubstring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("\nReplace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("\nIsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
        }
    }
}
