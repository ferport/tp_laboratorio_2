using System;

namespace Entidades
{
    public static class Calculadora
    {

        //Metodos
        #region
        /// <summary>
        /// Realiza la operacion requerida entre dos numeros
        /// </summary>
        /// <param name="num1">Primer operando</param>
        /// <param name="num2">Segundo operando</param>
        /// <param name="operador">Operacion requerida</param>
        /// <returns>El resultado de la operacion</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado = 0;
            if (!string.IsNullOrEmpty(operador)) 
            {
                operador = ValidarOperador(Convert.ToChar(operador));
            }
            
            switch(operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
            }
            return resultado;
        }

        /// <summary>
        /// Valida que el char sea un operador (+,-,*,/)
        /// </summary>
        /// <param name="operador">Char operador</param>
        /// <returns>Retorna un string ocn el operador deseado,de no ser un operador retorna +</returns>
        private static string ValidarOperador(char operador) 
        {
            string operacion = Convert.ToString(operador);
            if (!(operacion == "+" || operacion == "-" || operacion == "*" || operacion == "/")) 
            {
                operacion = "+";
            }

            return operacion;
        }
        #endregion

    }
}
