using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        /// <summary>
        /// Propiedad que se encarga de darle un valor al atributo numero en formato string.
        /// Valida el string
        /// </summary>
        private string NUMERO
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        /// <summary>
        /// Constructor que se encargade darle un valor al atributo numero
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }
        /// <summary>
        /// Sobrecarga de constructor que se encarga de igualar el atributo al parametro recibido de tipo "double"
        /// para darle un valor.
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero)
        {
            this.numero = numero;
        }
        /// <summary>
        /// Sobrecarga de constructor que se encarga de igualar la propiedad del atributo numero al parametro recibido de tipo "string"
        /// para darle un valor
        /// </summary>
        /// <param name="strNumero"></param>
        public Operando(string strNumero)
        {
            this.NUMERO = strNumero;
        }

        /// <summary>
        /// Metodo que se encarga de transformar un numero binario a decimal.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Un string con mensaje de error o el numero convertido en formato string</returns>
        public string BinarioDecimal(string binario)
        {
            string respuesta = string.Empty;
            string BinarioInverso = string.Empty;
            string arrayBinario = string.Empty;            
            int EnteroRetornado = 0;
            int enteroAux;
            float numero;
            if (EsBinario(binario))
            {
                numero = float.Parse(binario);
                enteroAux = (int)MathF.Floor(MathF.Abs(numero));
                arrayBinario = enteroAux.ToString();

                for (int i = arrayBinario.Length - 1; i >= 0; i--)
                {
                    BinarioInverso += arrayBinario[i];
                }
                for (int i = 0; i < BinarioInverso.Length; i++)
                {
                    if (BinarioInverso[i] == '1')
                    {
                        EnteroRetornado += (int)MathF.Pow(2, i);
                    }
                }
                respuesta = EnteroRetornado.ToString();
            }
            else
            {
                respuesta = "Valor inválido";
            }
            return respuesta;
        }

        /// <summary>
        /// Metodo que se encarga de transformar un numero decimal a binario recibiendo como parametro un double
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Un mensaje de error o el numero convertido en formato string</returns>
        public string DecimalBinario(double numero)
        {
            StringBuilder binarioInvertido = new StringBuilder();
            string binario = "Valor invalido";
            int dividendo = (int)(Math.Abs(numero));
            int resto;

            
            while (dividendo >= 2)
            {
                resto = dividendo % 2;
                binarioInvertido.Append(resto.ToString());
                dividendo = dividendo / 2;
            }
            binarioInvertido.Append(dividendo.ToString());

            if(EsBinario(binarioInvertido.ToString()))
            {
                char[] arrayDeCaracteres = binarioInvertido.ToString().ToCharArray();
                Array.Reverse(arrayDeCaracteres);
                binario = new string(arrayDeCaracteres);
            }
            
   
            return binario;
        }

        /// <summary>
        /// Sobrecarga de metodo que se encarga de convertir un numero decimal a binario recibiendo como parametro un string
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(string numero)
        {
            StringBuilder binarioInvertido = new StringBuilder();
            string binario = "Valor invalido";
            int dividendo = (int)(Math.Abs(Convert.ToDouble(numero)));
            int resto;


            while (dividendo >= 2)
            {
                resto = dividendo % 2;
                binarioInvertido.Append(resto.ToString());
                dividendo = dividendo / 2;
            }
            binarioInvertido.Append(dividendo.ToString());

            if (EsBinario(binarioInvertido.ToString()))
            {
                char[] arrayDeCaracteres = binarioInvertido.ToString().ToCharArray();
                Array.Reverse(arrayDeCaracteres);
                binario = new string(arrayDeCaracteres);
            }


            return binario;
        }

        /// <summary>
        /// Metodo que se encarga de validar si un numero es binario y quedarse con la parte entera del numero
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>True o False</returns>
        private bool EsBinario(string binario)
        {
            bool esValido = true;
            foreach (var item in binario)
            {
                if ((binario[0] == '-' && binario[0] == '+') && item == binario[0])
                {

                }
                else
                {
                    if(item == '.' || item == ',')
                    {
                        break;
                    }
                    else
                    {
                        if ((item != '0' && item != '1') && (binario[0] != '-'))
                        {
                            esValido = false;
                            break;
                        }
                    }
                }
            }

            return esValido;
        }

        /// <summary>
        /// Sobrecarga del operador '+'. Se encarga de sumar dos numeros.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>La suma de tipo "doble"</returns>
        public static double operator +(Operando num1, Operando num2)
        {
            return num1.numero + num2.numero;
        }
        /// <summary>
        /// Sobrecarga del operador '-'. Se encarga de restar dos numeros.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>La resta de tipo "doble"</returns>
        public static double operator -(Operando num1, Operando num2)
        {
            return num1.numero - num2.numero;
        }
        /// <summary>
        /// Sobrecarga del operador '*'. Se encarga de multiplicar dos numeros.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>La multiplicacion de tipo "doble"</returns>
        public static double operator *(Operando num1, Operando num2)
        {
            return num1.numero * num2.numero;
        }
        /// <summary>
        /// Sobrecarga del operador '/'. Se encarga de dividir dos numeros.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>La division de tipo "doble" o el MinValue en caso de division por 0</returns>
        public static double operator /(Operando num1, Operando num2)
        {
            double retorno = double.MinValue;

            if(num2.numero != 0)
            {
                retorno = num1.numero / num2.numero;
            }

            return retorno;
        }

        /// <summary>
        /// Metodo que se encarga de comprobar si el valor recibido es numerico.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>El numero en formato "doble" o 0</returns>
        private double ValidarOperando(string strNumero) 
        {
            double numero = 0;
            StringBuilder strNumeroDecimal = new StringBuilder(strNumero);
            strNumeroDecimal.Replace('.', ',');
            double.TryParse(strNumeroDecimal.ToString(), out numero);

            return numero;

        }
    }
}
