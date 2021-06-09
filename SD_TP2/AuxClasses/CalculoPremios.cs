using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SD_TP2.AuxClasses
{
    public static class CalculoPremios
    {
        /// <summary>
        /// Função para converter uma string em um array de inteiros consoante um caracter de divisão
        /// </summary>
        /// <param><c>stringArray</c> é a string para ser convertida</param>
        /// <param><c>character</c> é o caracter de divisão da string</param>
        /// <returns>Retorna uma array de inteiros</returns>
        public static int[] ConvertArrayToInt(string stringArray,char character)
        {
            var newStringArray = stringArray.Split(character);

            
                var newIntArray = new List<int>();
                
                foreach(var element in newStringArray)
                {
                    newIntArray.Add(int.Parse(element));
                }
                return newIntArray.ToArray();
            
        }
        /// <summary>
        /// Função responsável por calcular os premios(1º,2º,3º) de todos os vencedores de um sorteio
        /// </summary>
        /// <param><c>numeros</c> são os numeros da chave a ser avaliada</param>
        /// <param><c>estrelas</c> são as estrelas da chave a ser avaliada</param>
        /// <param><c>numeros_v</c> são os numeros da chave sorteada(vencedora)</param>
        /// <param><c>estrelas_v</c> são as estrelas da chave sorteada(vencedora)</param>
        /// <returns>Returna um inteiro que corresponde ao prémio atribuido á chave a ser avaliada</returns>
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
