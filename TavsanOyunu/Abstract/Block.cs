using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TavsanOyunu.Abstract
{
    public abstract class Block
    {
        public void Run()
        {
            Console.WriteLine("Tavşan Bloklandı, devam etmek için lütfen farklı yön kombinasyonları deneyin");
        }
    }
}