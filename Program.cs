//N1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardDat
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку символов: ");
            char input;
            int spaceCount = 0;
            do
            {
                input = Console.ReadKey().KeyChar;

                if (input == ' ')
                    spaceCount++;
            }
            while (input != '.');

            Console.WriteLine("Кол-во пробелов: " + spaceCount);

            Console.ReadKey();
        }
    }
}

/*N3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BigLetter
{
    public static void Main()
    {
        int e, count = 0;
        char i;
        do
        {
            Console.WriteLine("Введите символ");
            do
            {
                e = Console.Read();
                i = (char)e;
            } while (i == '\n' | i == '\r');



            if (e >= 65 && e <= 90)
            {
                e += 32;
                i = (char)e;
                Console.WriteLine(i);
                count++;

            }
            else if (e >= 97 && e <= 122)
            {
                e -= 32;
                i = (char)e;
                Console.WriteLine(i);
                count++;
            }
            else if (e == 46)
            {
                break;
            }
            else
            {
                i = (char)e;
                Console.WriteLine(i);
            }


        } while (e != 46);
        Console.WriteLine("Всего введено " + count + " символов");

    }

}

N2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class BigLetter
{
    public static void Main()
    {
        Console.Write("Введите номер трамвайного билета:  ");
        string str = Console.ReadLine();
        char[] ch = new char[str.Length];
        ch = str.ToCharArray();
        int[] ticketNumber = ch.Select(s => int.Parse(s.ToString())).ToArray();

        if (ch.Length == 6)
        {
            int leftNumber = 0;
            int rightNumber = 0;

            for (int i = 0; i < ch.Length; i++)
            {
                if (i < 3)
                {
                    leftNumber += ticketNumber[i];
                }

                else rightNumber += ticketNumber[i];
            }

            if (leftNumber == rightNumber)
            {
                Console.WriteLine("У вас счастливый билет: {0} = {1}", leftNumber, rightNumber);
            }

            else Console.WriteLine("У вас не счастливый билет: {0} != {1}", leftNumber, rightNumber);
        }

        else Console.WriteLine("Число введено не правильно!");

        Console.Read();
    }
}

N4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целые положительные числа: ");
            int a = 3, b = 7;

            for (int i = a; i <= b; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    Console.Write(i.ToString() + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}*/
