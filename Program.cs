using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytoveDruzstvo
{
    class Program
    {
        static void Main(string[] args)
        {
            Byt byt = new Byt();
            int volba = 0;
            try
            {            
                do
                {
                    Console.WriteLine("Vyber moznost:");
                    Console.WriteLine("\t 1. Pridej cloveka");
                    Console.WriteLine("\t 2. Vypis cloveka/bytu");
                    Console.WriteLine("\t 3. Vyber index a smaz obyvatele");
                    Console.WriteLine("\t 4. Uprav cloveka");
                    Console.WriteLine("\t 5. Konec programu");
               
                    volba = Int32.Parse(Console.ReadLine());
                    switch (volba)
                    {
                        case 1:
                            byt.PridejCloveka();
                            break;
                        case 2:
                            byt.VypisCloveka();
                            break;
                        case 3:
                            byt.DeleteMan();
                            break;
                        case 4:
                            byt.UpravCloveka();
                            break;
                    }
                } while (volba !=5);
                }
            catch (Exception)
            {

                Console.WriteLine("Spatna volba.");
                Console.ReadKey();
            }
        }
    }
}
