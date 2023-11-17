using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TkachukSS.Sprint5.Task0.V27.Lib;

namespace Tyuiu.TkachukSS.Sprint5.Task0.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x = 3;

            Console.WriteLine("X = " + x);

            Console.WriteLine("***************************************************************************");

            Console.WriteLine("****************************РЕЗУЛЬТАТ**************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл " + res);
            Console.WriteLine("Создан");
            Console.ReadKey();

        }
    }
}
