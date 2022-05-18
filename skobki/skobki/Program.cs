using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skobki
{
    internal class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string first, second;
            int k = 0;
            int number = 0;
            for (int i = 0; i < text.Length - 1;)
            {
                first = text.Substring(i,1);
                second = text.Substring(i + 1,1);
                if ((first == "(") && (second == ")"))
                {
                    text = text.Remove(i, 2);
                    if (i < number)
                        k++;
                    number = i;
                    i = 0;
                }
                else i++;
            }

            if (text == "")
                Console.WriteLine("Выражение корректно");
            else Console.WriteLine("Выражение некорректно");

            Console.WriteLine("Глубина вложенных скобок:" + (k+1));
            Console.ReadKey();
        }
    }
}
