using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytoveDruzstvo
{
    class Clovek
    {
        public string Jmeno { get; set; }
        public float Vek { get; set; }
        public Clovek(string jmeno, float vek)
        {
            Jmeno = jmeno;
            Vek = vek;
        }
        public void VypisPopis()
        {
            Console.WriteLine("Jmeno: {0}", Jmeno);
            Console.WriteLine("Vek: {0}", Vek);
        }
       
    }
}
