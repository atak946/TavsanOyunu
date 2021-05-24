using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TavsanOyunu.Services
{
    public class NavigationService
    {
        private int RabbitX { get; set; }
        private int RabbitY { get; set; }

        public void Run(char navigationChar)
        {
            switch (navigationChar)
            {
                case 'N':
                    Next();
                    break;

                case 'P':
                    Prev();
                    break;

                case 'L':
                    Left();
                    break;

                case 'R':
                    Right();
                    break;

                case 'J':
                    Jump();
                    break;

                case 'İ':
                    Lean();
                    break;
            }
        }

        private void Next()
        {
            RabbitY--;
        }

        private void Prev()
        {
            RabbitY++;
        }

        private void Left()
        {
            RabbitX++;
        }

        private void Right()
        {
            RabbitX--;
        }

        private void Jump()
        {
        }

        private void Lean()
        {
        }
    }
}