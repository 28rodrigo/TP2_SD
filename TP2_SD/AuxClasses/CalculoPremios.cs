using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP2_SD.AuxClasses
{
    public static class CalculoPremios
    {
        public static int[] ConvertArrayToInt(string stringArray)
        {
            var newStringArray = stringArray.Split(',');

            
                var newIntArray = new List<int>();
                
                foreach(var element in newStringArray)
                {
                    newIntArray.Add(int.Parse(element));
                }
                return newIntArray.ToArray();
            
        }

        public static int CalcularPremio(int[] numeros, int[] estrelas, int[] numeros_v, int[] estrelas_v)
        {
            int numerosAcertados = 0;
            int estrelasAcertadas = 0;

            foreach(var element in numeros)
            {
                if (numeros_v.Contains(element)) numerosAcertados++;
            }
            foreach (var element in estrelas)
            {
                if (estrelas_v.Contains(element)) estrelasAcertadas++;
            }

            if(numerosAcertados==5)
            {
                if (estrelasAcertadas == 2) return 1;
                else if (estrelasAcertadas == 1) return 2;
                else return 3;
            }else if(numerosAcertados==4)
            {
                if (estrelasAcertadas == 2) return 4;
                else if (estrelasAcertadas == 1) return 5;
                else return 7;
            }else if(numerosAcertados==3)
            {
                if (estrelasAcertadas == 2) return 6;
                else if (estrelasAcertadas == 1) return 9;
                else return 10;
            }else if(numerosAcertados==2)
            {
                if (estrelasAcertadas == 2) return 8;
                else if (estrelasAcertadas == 1) return 12;
                else return 13;
            }
            else if (numerosAcertados == 1)
            {
                if (estrelasAcertadas == 2) return 11;
                else return 0;
            }
            else
            {
                return 0;
            }


        }
    }
}
