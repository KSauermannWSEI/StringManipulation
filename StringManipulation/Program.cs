using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Ktury ipsum inny tekst";
            //text = text.ToUpper();
            //text = text.ToLower();
            //text = text.Substring(0, 5);
            //var arr = text.Split(' ')[0]; //Split dzieli srting na tablicę zanków (char) [0] pobiera pierwszą wartość
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //string[] arr2 = text.Split(' ');
            //text = string.Join("_", arr2);
            //text = text.Replace("Ktury", "Który");
            //text = text.Replace("ipsum ", "");
            //text = text.Remove(7, 6);
            //text = "Super tekst" + text + "3";
            text = $"Super tekst {text}";

            StringBuilder stringBuilder = new StringBuilder(text);
            stringBuilder.Append(" trochę późno");
            stringBuilder.AppendLine(" ale nadal jasno");
            stringBuilder.AppendLine(" ale nadal jasno");
            stringBuilder.Replace("nadal", "coś");

            Console.WriteLine(stringBuilder.ToString());
            Console.Read();
        }
    }
}
