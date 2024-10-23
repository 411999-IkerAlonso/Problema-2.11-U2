using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Problema_2._11
{
    public class Carta
    {
        public int Numero { get; set; }
        public string Palo { get; set; }

        public Carta(int numero, string palo)
        {
            if (numero >= 1 && numero <= 12 && numero != 8 && numero != 9)
            {
                Console.WriteLine("El numero no debe ser menor a 1 o mayor a 12 o igual a 8 o 9");
                Numero = numero;
            }
            else if (numero == 8)
            {
                Numero = 10;
            }
            else if (numero == 9)
            {
                Numero = 11;
            }
            else if (numero == 10)
            {
                Numero = 12;
            }
            if (palo == "Espada" || palo == "Basto" || palo == "Oro" || palo == "Copas")
            {
                Palo = palo;
            }
            else
            {
                Console.WriteLine("Palo No Disponible");
                Palo = string.Empty;
            }
        }
    }
}
