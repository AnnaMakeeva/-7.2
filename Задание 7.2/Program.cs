using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба: ");

            int a = Convert.ToInt32(Console.ReadLine());//создаем переменные
           
            double V, S;
            GetV (a, out V, out S);

            Console.WriteLine(V);
            
            Console.WriteLine(S);
            Console.ReadKey();


        }

        static void GetV(int a, out double V, out double S)
        {
            V = Math.Pow(a,3);        //вычисляем объем куба
            S = Math.Pow(a, 2) * 6;  //вычисляем площадь поверхности куба
        }
    }
      
}
