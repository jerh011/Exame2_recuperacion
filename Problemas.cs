using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2_Recuperacion
{
    public class Problemas
    {

        public int[] matriz()
        {
            Random rnd = new Random();
            int[] matriz = new int[10];
            for (int i = 0; i < 10; i++)
                matriz[i] = rnd.Next(1, 100);

            return matriz;
        }
        public void Imprimirmatriz(int[] matriz)
        {
            for (int i = 0; i < matriz.Length; i++)
                Console.WriteLine(matriz[i]);

        }
        public int[] Ordenar(int[] matriz)
        {

            int j, auxiliar;
            for (int i = 0; i < matriz.Length; i++)
            {
                auxiliar = matriz[i];
                j = i - 1;
                while (j >= 0 && auxiliar > matriz[j])
                {
                    matriz[j + 1] = matriz[j];
                    j--;
                }
                matriz[j + 1] = auxiliar;
            }
            return matriz;
        }
        public void BusquedaBinaria(int[] matriz)
        {
            Console.WriteLine("que numero esta buscando?");
            int buscar = Convert.ToInt32(Console.ReadLine());
            int inicio = 0;
            int fin = matriz.Length;
            int medio = 0;
            int indice = -1;
            while (inicio <= fin)
            {
                
                if (matriz[medio] == buscar)
                {
                    indice = medio;
                    break;
                }
                 if (inicio <matriz[medio])
                    inicio = medio + 1;
                else
                    fin = medio - 1;

                medio = (inicio + fin) / 2;

            }

            if (indice == -1)
                Console.WriteLine("no se encontro el valor");
            else
               Console.WriteLine($"Encontraste {buscar} en la posiscion {indice}");
            
        }

        public void IngreseCurp() { 
          
            
            Console.WriteLine("ingrese la curp");
            string curp=Convert.ToString(Console.ReadLine());
          
        
           
            char sexo=curp[10];
            int x = 0;
            string fecha="";

            for (int i = 4; i < 10; i++)
            {
                if (i <= 9) { 
                if (x == 2 || x == 5)
                {
                    fecha += "/";
                    x++;
                }

                fecha += curp[i];
                x++;
                }
               

            }
            



            imprecionCurp(fecha,curp,sexo);
        }


        public void imprecionCurp(string year2,string curp,char sexo) {

            DateOnly fecha = DateOnly.ParseExact(year2, "yy/MM/dd", CultureInfo.InvariantCulture);
            if(sexo=='F')
            Console.WriteLine($"Para una CURP igual a {curp}: El mensaje de salidad debe ser: Usted es de sexo femenino  y su fecha de nacimiento es {fecha}.");
            else
                Console.WriteLine($"Para una CURP igual a {curp}: El mensaje de salidad debe ser: Usted es de sexo masculino  y su fecha de nacimiento es {fecha}.");
        }

    }
}