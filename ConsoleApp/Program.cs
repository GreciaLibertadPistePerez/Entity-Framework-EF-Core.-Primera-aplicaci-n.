using System;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            char lectura; do
            {
                Console.WriteLine("[A]gregar autor | [M]odificar autor | [E]liminar autor | [V]erautores | [S]alir");
                Console.Write("Selecciona una opción: ");
                lectura = Char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine(); switch (lectura)

                {
                    case 'A':
                        AddAuthor(); break;
                    case 'M': ModifyAuthor(); break;
                    case 'E': DeleteAuthor(); break;
                    case 'V': ShowAuthors(); break;
                    case 'S': Console.WriteLine("Adiós. Programa finalizado."); break;
                    default: break;
                }
                Console.WriteLine();
            } while (lectura != 'S'); Console.WriteLine("");

            static void AddAuthor() { Console.WriteLine("Agregando un autor..."); }
            static void ShowAuthors() { Console.WriteLine("Mostrando autores..."); }

        }

        private static void DeleteAuthor()
        {
            throw new NotImplementedException();
        }

        private static void ModifyAuthor()
        {
            throw new NotImplementedException();
        }
    }
}
