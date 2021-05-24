using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TavsanOyunu.Abstract
{
    public abstract class Die
    {
        public void Run()
        {
            Console.WriteLine("Tavşan öldü, tekrar deneyin");
        }
    }
}