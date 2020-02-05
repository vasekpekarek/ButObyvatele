using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytoveDruzstvo
{
    class Byt
    {
        List<Clovek> lide;
        public Byt()
        {
            lide = new List<Clovek>();
        }
        public void PridejCloveka()
        {
            Console.WriteLine("Zadani cloveka");
            Console.Write("Jmeno: ");
            string jmeno = Console.ReadLine();
            Console.Write("Vek: ");
            float vek = float.Parse(Console.ReadLine());
            Clovek clovek = new Clovek(jmeno, vek);
            lide.Add(clovek);
        }
       
        public void VypisCloveka()
        {
            foreach (Clovek clovek in lide)
            {
                clovek.VypisPopis();
            }
        }
        public int VyberIndex()
        {
            for (int i = 0; i < lide.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, lide[i].Jmeno);
            }
            Console.WriteLine("Zadej pozici, kterou chces smazat: ");
            int delMan = Int32.Parse(Console.ReadLine()) - 1;
            if (delMan >=0 && delMan < lide.Count)
            {
                return delMan;
            }
            else
            {
                Console.WriteLine("Spatne poradove cislo.");
                return 0;
            }
            
        }
        public void DeleteMan()
        {
            Console.WriteLine("Smazani cloveka");
            int index = VyberIndex();
            Console.WriteLine("Clovek byl smazan.");
            lide.Remove(lide[index]);
        }
        public void UpravCloveka()
        {
            Console.WriteLine("Uprava cloveka: ");
            int index = VyberIndex();
            Clovek clovek = lide[index];
            Console.WriteLine("Chces upravit jmeno? A/N");
            if (Console.ReadLine().ToLower() == "a")
            {
                Console.WriteLine("Zadej nove jmeno: ");
                clovek.Jmeno = Console.ReadLine();
            }
            Console.WriteLine("Chces upravit vek? A/N");
            if (Console.ReadLine().ToLower() == "a")
            {
                Console.WriteLine("Zadej novy vek: ");
                clovek.Vek = Int32.Parse(Console.ReadLine());
            }

        }

    }
}
