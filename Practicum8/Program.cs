using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Practicum8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str, res;
            string space = " ";


            while (true)
            {
                try
                {
                    Console.Write("Введите сообщение: ");
                    str = Console.ReadLine();
                    if (str.Length == 0) throw new Exception("Пустая строка. Введите что нибудь!");
                    break;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Regex regex = new Regex(@"\b\w\b", RegexOptions.IgnoreCase);
            Regex regex2 = new Regex(@"\s+");

            str = regex.Replace(str, "");
            res = regex2.Replace(str, space);
            Console.WriteLine($"Сообщение без однобуквенных слов: {res}");
        }
    }
}
