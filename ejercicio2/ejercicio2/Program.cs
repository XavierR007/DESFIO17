namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool band=true;
            int num = int.Parse(Console.ReadLine());
            
            for (int n=2; n<num; n++)
            {
                if (num % n == 0)
                {
                    band = false;
                }
            }
            if (band)
            {
                Console.WriteLine("es primo");
            }

            
            }
        }
    }
