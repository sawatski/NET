using System;
//creating exceptions
namespace Labs
{
    class Program
    {
        static void ProcessString(string s)
        {
            if (s == null)
            {
                throw new ArgumentNullException();
            }
        }

        public static void Main()
        {
            try
            {
                string s = null;
                ProcessString(s);
                ProcessString("gkhbrsk");
            }
            // Специфика:
            catch (ArgumentNullException e)
            {
                Console.WriteLine("{0} Первое исключение.", e);
            }
            // Рандом:
            catch (Exception e)
            {
                Console.WriteLine("{0} Второе исключение.", e);
            }
            finally
            {
                Console.WriteLine("Исключений не было");
            }
        }
    }
}
