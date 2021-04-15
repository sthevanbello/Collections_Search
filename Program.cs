using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaCollections
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Month> months = new List<Month>
                {
                    new Month("Janeiro", 31),
                    new Month("Janeiro", 31),
                    new Month("Fevereiro", 28),
                    new Month("Março", 31),
                    new Month("Abril", 30),
                    new Month("Maio", 31),
                    new Month("Junho", 30),
                    new Month("Julho", 31),
                    new Month("Agosto", 31),
                    new Month("Setembro", 30),
                    new Month("Outubro", 31),
                    new Month("Novembro", 30),
                    new Month("Dezembro", 31)
                };
            PrintMonths(months);

            Console.WriteLine("\nLinq\n");

            var listLinq = months.Where(m => m.Days == 31).OrderBy(m => m.Name);
            var names = months.Where(m => m.Days == 31).OrderBy(m => m.Name).Select(m => m.Name);
            var days = months.Where(m => m.Days == 31).OrderBy(m => m.Name).Select(m => m.Days);

            //IEnumerable<Month> listLinq = months.Where(m => m.Days == 31).OrderBy(m => m.Name);

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            PrintMonths(listLinq);

            Console.ReadKey();
        }

        private static void PrintMonths(IEnumerable<Month> months)
        {
            Console.WriteLine();
            foreach (var month in months)
            {
                Console.WriteLine(month);
            }
        }
    }
}
