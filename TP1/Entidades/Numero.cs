using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Entidades
{
    public class Numero
    {
        //Atributos
        #region
        private double numero;
        #endregion

        //Propiedades
        #region
        public string SetNumero
        {
        
            set 
            {
                double numero = ValidarNumero(value);
                this.numero = numero;
            } 
             
        }
        #endregion

        //Constructores
        #region
        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string strNumero)
        {

            this.numero = this.ValidarNumero(strNumero);

        }
        #endregion

        //Metodos
        #region
        /// <summary>
        /// Convierte un string de numeros binarios a uno de numeros decimales
        /// </summary>
        /// <param name="binario">String de numeros binarios a convertir</param>
        /// <returns>String de numeros binario convertido a decimal, de no serlo devuelve "Valor invalido."</returns>
        public string BinarioDecimal(string binario) 
        {
            int num = 0;

            if (EsBinario(binario))
            {
                char[] array = binario.ToCharArray();
                Array.Reverse(array);
                

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == '1')
                    {
                    
                        num += (int)Math.Pow(2, i);
                    }
                }
                return Convert.ToString(num);
            }
            else 
            {
                return "Valor invalido."; 
            }
        }

        /// <summary>
        /// Convierte un string de numeros decimales a uno de numeros binarios
        /// </summary>
        /// <param name="strNumero">String de numeros decimales a convertir</param>
        /// <returns>String de numeros decimales convertido a binario, de no serlo devuelve "Valor invalido."</returns>
        public string DecimalBinario(string strNumero)
        {
            if (!string.IsNullOrEmpty(strNumero) && strNumero != "Valor invalido.") {
                double numero = Convert.ToDouble(strNumero);
                return DecimalBinario(numero);
            }
            else
            {
                return "Valor invalido.";
            }
            
        }

        /// <summary>
        /// Convierte un numero decimal a un string de numeros binarios
        /// </summary>
        /// <param name="numero">Numero decimal a convertir</param>
        /// <returns>Numeros decimal convertido a un string de numeros binarios</returns>
        public string DecimalBinario(double numero)
        {
            numero = Math.Abs(numero);
            string cadena = "";
            while(numero > 0)
            {
                if (numero % 2 == 0)
                {
                    cadena = "0" + cadena;
                }
                else
                {
                    cadena = "1" + cadena;
                }
                numero = numero / 2;
                numero = Math.Truncate(numero);
            }
            Console.WriteLine(cadena);
            return cadena;
        }

        /// <summary>
        /// Valida si un strings es una cadena de numeros binarios
        /// </summary>
        /// <param name="binario">String a validar</param>
        /// <returns>True si el string es una cadena de numeros binarios. False si la cadena contiene algo diferentes a 0 o 1</returns>
        private bool EsBinario(string binario) 
        {
            if (Regex.IsMatch(binario, @"^[0 - 1]"))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        /// <summary>
        /// Valida si un string posee solo numeros y la convierte en un double
        /// </summary>
        /// <param name="strNumero">String a validar</param>
        /// <returns>String convertido a double, si no es posible retorna 0</returns>
        private double ValidarNumero(string strNumero)
        {
            double numParse;
            if (double.TryParse(strNumero, out numParse))
            {

                //numParse = double.Parse(strNumero);
                return numParse;
            }

            return 0;
        }

        #endregion

        //Sobrecargas de operadores
        #region
        /// <summary>
        /// Resta dos atributos numero de un objeto Numero
        /// </summary>
        /// <param name="num1">Primer operando</param>
        /// <param name="num2">Segundo operando</param>
        /// <returns>Resultado de la operacion</returns>
        public static double operator -(Numero num1, Numero num2) 
        {
            return num1.numero - num2.numero;
        }

        /// <summary>
        /// Suma dos atributos numero de un objeto Numero
        /// </summary>
        /// <param name="num1">Primer operando</param>
        /// <param name="num2">Segundo operando</param>
        /// <returns>Resultado de la operacion</returns>
        public static double operator +(Numero num1, Numero num2)
        {
            return num1.numero + num2.numero;
        }

        /// <summary>
        /// Multiplica dos atributos numero de un objeto Numero
        /// </summary>
        /// <param name="num1">Primer operando</param>
        /// <param name="num2">Segundo operando</param>
        /// <returns>Resultado de la operacion</returns>
        public static double operator *(Numero num1, Numero num2)
        {
            return num1.numero * num2.numero;
        }

        /// <summary>
        /// Divide dos atributos numero de un objeto Numero
        /// </summary>
        /// <param name="num1">Primer operando</param>
        /// <param name="num2">Segundo operando</param>
        /// <returns>Resultado de la operacion</returns>
        public static double operator /(Numero num1, Numero num2)
        {
            if (num2.numero == 0)
            {
                return double.MinValue;
            }
            return num1.numero / num2.numero;
        }
  
        #endregion

    }
}
