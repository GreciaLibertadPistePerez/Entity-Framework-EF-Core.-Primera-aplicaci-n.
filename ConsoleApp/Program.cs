using BooksApp.Dataa;
using BooksApp.Domaiin;
using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        private static BooksContext context = new BooksContext();
        static void Main(string[] args)
        {
            char lectura;
            context.Database.EnsureCreated();
            do
            {
                Console.WriteLine("[A]gregar autor | [M]odificar autor | [E]liminar autor | "
               +
                "[V]er autores | [S]alir");
                Console.Write("Selecciona una opción: ");
                lectura = Char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
                switch (lectura)
                {
                    case 'A':
                        AddAuthor();
                        break;
                    case 'M':
                        ModifyAuthor();
                        break;
                    case 'E':
                        DeleteAuthor();
                        break;
                    case 'V':
                        ShowAuthors("Autores registrados");
                        break;
                    case 'S':
                        Console.WriteLine("Adiós. Programa finalizado.");
                        break;
                    default:
                        break;
                }
                Console.WriteLine();
            } while (lectura != 'S');
            Console.WriteLine("");
        }
        
        }
    }
}
