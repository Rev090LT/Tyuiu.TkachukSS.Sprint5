using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TkachukSS.Sprint5.Task4.V7.Lib
{
    public class DataService : ISprint5Task4V7
    {
        public double LoadFromDataFile(string path)
        {
            string readnumb = File.ReadAllText(path);
            double res = (1 + Math.Cos(Convert.ToDouble(readnumb)) + Math.Pow(Convert.ToDouble(readnumb), 3));
            return res;         
        }
    }
}
