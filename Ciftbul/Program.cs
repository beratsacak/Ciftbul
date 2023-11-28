using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciftbul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cifttek cifttek = new Cifttek();
            bool sonucc = cifttek.tekcift(10);
            if (sonucc)
            {
                Console.WriteLine("Sayı Çift");
            }
            else
            {
                Console.WriteLine("Sayı Tektir");
            }

        }
    }
    public class Cifttek
    {
        bool sonuc;
        public bool tekcift(int x)
        {
            if (x % 2 == 0)
            {
                sonuc = true;
            }
            else
            {
                sonuc = false;
            }
            return sonuc;
        }
    }
}
