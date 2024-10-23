using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2._11
{
    public class Baraja
    {
        Carta[] cartas = new Carta[40];
        public Baraja()
        {
            for (int i = 0; i < 40; i++)
            {
                if(i <10)
                {
                    cartas[i] = new Carta(i, "Espada");
                }
                else if(i>10 && i <20)
                {
                    for(int j = 1; j < 10; j++)
                    {
                        cartas[i] = new Carta(j, "Basto");
                    }
                }
                else if(i>20 && i <30)
                {
                    for (int j = 1; j < 10; j++)
                    {
                        cartas[i] = new Carta(j, "Oro");
                    }
                }
                else if( i>30 && i <40)
                {
                    for (int j = 1; j < 10; j++)
                    {
                        cartas[i] = new Carta(j, "Oro");
                    }
                }
            }
        }

        public void Barajar()
        {
            Random rnd = new Random();
            for(int i = 0;i < 40; i++)
            {
                cartas[i]= 
            }
        }
    }
}
