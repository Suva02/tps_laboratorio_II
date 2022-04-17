using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// validará y realizará la operación pedida entre ambos números segun el operador
        /// </summary>
        /// <param name="Operando uno"></param>
        /// <param name="Operando dos"></param>
        /// <param name="Operador"></param>
        /// <returns> Resultado de la operacion </returns>
        public static double Operar(Operando numUno, Operando numDos, char operador)
        {
            char operadorRetornado = Calculadora.ValidarOperador(operador);
            double operacion = 0;

            if(operadorRetornado == '+')
            {
                operacion = numUno + numDos;
            }
            else
            {
                if(operadorRetornado == '-')
                {
                    operacion = numUno - numDos;
                }
                else
                {
                    if(operadorRetornado == '*')
                    {
                        operacion = numUno * numDos;
                    }
                    else
                    {
                        if(operadorRetornado == '/')
                        {
                            operacion = numUno / numDos;
                        }
                    }
                }
            }

            return operacion;

        }

        /// <summary>
        /// Valida el operador recibido
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>El operador que se recibio por parametro</returns>
        private static char ValidarOperador(char operador)
        {
            char operadorRetornado = '+';

            if(operador == '+' || operador == '-' || operador == '*' || operador == '/')
            {
                operadorRetornado = operador;
            }

            return operadorRetornado;


        }
    }
}
