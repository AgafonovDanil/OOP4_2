using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП4_2
{
    class Book
    {
        private int YearIssue;
        public int YearBook
        {
            get
            {
                return YearIssue;
            }
            set
            {
                if (value > 1940 && value < 2020)
                    Console.WriteLine("Год выпуска  состоит в указанном диапазоне. Год выпуска: " + value);

                else
                    Console.WriteLine("Год выпуска не состоит в диапозоне  от 1940 до 2020");
            }
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год в диапозоне от 1940 до 2020");

            int YearBook = Convert.ToInt32(Console.ReadLine());
            Book newBook = new Book();

            newBook.YearBook = YearBook;


            Console.ReadLine();
        }
    }
}
