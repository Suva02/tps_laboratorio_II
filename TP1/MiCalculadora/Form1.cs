using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        private double doble;

        /// <summary>
        /// Constructor que se encarga de inicializar todos los componentes del formulario y el atributo de la clase
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
            this.doble = 0;
        }

        /// <summary>
        /// Metodo que se encarga de llamar a un metodo de otra clase para realizar una operacion.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns>El resultado de esa operacion</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando numeroUno = new Operando(numero1);
            Operando numeroDos = new Operando(numero2);
            double resultado;
              
            resultado = Calculadora.Operar(numeroUno, numeroDos, char.Parse(operador));

            return resultado;
        }

        /// <summary>
        /// Evento que se encarga de efectuar todas las operaciones y mostrarlas en el form.
        /// Se encarga de validar todo lo necesario para poder mostrar las operaciones de forma correcta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string concatenacion;
            double resultado;
            string stringResultado;

            if (this.cmbOperador.Text!= "")
            {
                if(!double.TryParse(this.txtNumero1.Text, out this.doble) && double.TryParse(this.txtNumero2.Text, out this.doble))
                {
                    resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
                    stringResultado = resultado.ToString();
                    concatenacion = "0" + " " + this.cmbOperador.Text + " " + this.txtNumero2.Text + " " + "=" + stringResultado;
                    this.lblResultado.Text = stringResultado;
                    this.lstOperaciones.Items.Add(concatenacion);
                }
                else
                {
                    if (double.TryParse(this.txtNumero1.Text, out this.doble) && !double.TryParse(this.txtNumero2.Text, out this.doble))
                    {
                        resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
                        stringResultado = resultado.ToString();
                        concatenacion = this.txtNumero1.Text + " " + this.cmbOperador.Text + " " + "0" + " " + "=" + stringResultado;
                        this.lblResultado.Text = stringResultado;
                        this.lstOperaciones.Items.Add(concatenacion);
                    }
                    else
                    {
                        if ((this.txtNumero1.Text.Contains("*") || this.txtNumero1.Text.Contains("+") || this.txtNumero1.Text.Contains("-") || this.txtNumero1.Text.Contains("/")) && !double.TryParse(this.txtNumero2.Text, out this.doble))
                        {
                            resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
                            stringResultado = resultado.ToString();
                            concatenacion = "0" + " " + this.cmbOperador.Text + " " + "0" + " " + "=" + stringResultado;
                            this.lblResultado.Text = stringResultado;
                            this.lstOperaciones.Items.Add(concatenacion);
                        }
                        else
                        {
                            if ((this.txtNumero2.Text.Contains("*") || this.txtNumero2.Text.Contains("+") || this.txtNumero2.Text.Contains("-") || this.txtNumero2.Text.Contains("/") ) && !double.TryParse(this.txtNumero1.Text, out this.doble))
                            {
                                resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
                                stringResultado = resultado.ToString();
                                concatenacion = "0" + " " + this.cmbOperador.Text + " " + "0" + " " + "=" + stringResultado;
                                this.lblResultado.Text = stringResultado;
                                this.lstOperaciones.Items.Add(concatenacion);
                            }
                            else
                            {
                                if (this.txtNumero1.Text.Contains(" ") && this.txtNumero2.Text.Contains(" "))
                                {
                                    resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
                                    stringResultado = resultado.ToString();
                                    concatenacion = "0" + " " + this.cmbOperador.Text + " " + "0" + " " + "=" + stringResultado;
                                    this.lblResultado.Text = stringResultado;
                                    this.lstOperaciones.Items.Add(concatenacion);
                                }
                                else
                                {
                                    if (!double.TryParse(this.txtNumero1.Text, out this.doble) && !double.TryParse(this.txtNumero2.Text, out this.doble))
                                    {
                                        resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
                                        stringResultado = resultado.ToString();
                                        concatenacion = "0" + " " + this.cmbOperador.Text + " " + "0" + " " + "=" + stringResultado;
                                        this.lblResultado.Text = stringResultado;
                                        this.lstOperaciones.Items.Add(concatenacion);
                                    }
                                    else
                                    {
                                        resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
                                        stringResultado = resultado.ToString();
                                        concatenacion = this.txtNumero1.Text + " " + this.cmbOperador.Text + " " + this.txtNumero2.Text + " " + "=" + stringResultado;
                                        this.lblResultado.Text = stringResultado;
                                        this.lstOperaciones.Items.Add(concatenacion);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Evento que se encarga de llamar a un Metodo para limpiar el formulario al cargarse.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Metodo que se encarga de limpiar el formulario
        /// </summary>
        private void Limpiar()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox || item is Label)
                {
                    item.Text = string.Empty;
                }
            }
            this.cmbOperador.SelectedIndex = 0;
        }

        /// <summary>
        /// Evento que al darle click, limpia el formulario llamando al metodo "Limpiar"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Evento que se encarga de preguntarle al usuario si desea cerrar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult seCierra = MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(seCierra != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Evento que se encarga de cerrar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Evento que se encarga de llamar al metodo "DecimalBinario" para para transformar un numero decimal a binario
        /// y mostrar la conversion en el formulario (con sus respectivas validaciones).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando conversion = new Operando();
            double resultado;
            string valor;
            string stringResultado;

            if (this.cmbOperador.Text != "")
            {
                if (!double.TryParse(this.txtNumero1.Text, out this.doble) && double.TryParse(this.txtNumero2.Text, out this.doble))
                {
                    resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
                    stringResultado = resultado.ToString();
                    this.lblResultado.Text = stringResultado;
                    this.lstOperaciones.Items.Add("0");
                }
                else
                {
                    if (double.TryParse(this.txtNumero1.Text, out this.doble) && !double.TryParse(this.txtNumero2.Text, out this.doble))
                    {
                        resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
                        stringResultado = resultado.ToString();
                        this.lblResultado.Text = stringResultado;
                        this.lstOperaciones.Items.Add("0");
                    }
                    else
                    {
                        if ((this.txtNumero1.Text.Contains("*") || this.txtNumero1.Text.Contains("+") || this.txtNumero1.Text.Contains("-") || this.txtNumero1.Text.Contains("/")) && !double.TryParse(this.txtNumero2.Text, out this.doble))
                        {
                            resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
                            stringResultado = resultado.ToString();
                            this.lblResultado.Text = stringResultado;
                            this.lstOperaciones.Items.Add("0");
                        }
                        else
                        {
                            if ((this.txtNumero2.Text.Contains("*") || this.txtNumero2.Text.Contains("+") || this.txtNumero2.Text.Contains("-") || this.txtNumero2.Text.Contains("/")) && !double.TryParse(this.txtNumero1.Text, out this.doble))
                            {
                                resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
                                stringResultado = resultado.ToString();
                                this.lblResultado.Text = stringResultado;
                                this.lstOperaciones.Items.Add("0");
                            }
                            else
                            {
                                if (this.txtNumero1.Text.Contains(" ") && this.txtNumero2.Text.Contains(" "))
                                {
                                    resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
                                    stringResultado = resultado.ToString();
                                    this.lblResultado.Text = stringResultado;
                                    this.lstOperaciones.Items.Add("0");
                                }
                                else
                                {
                                    if (!double.TryParse(this.txtNumero1.Text, out this.doble) && !double.TryParse(this.txtNumero2.Text, out this.doble))
                                    {
                                        resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
                                        stringResultado = resultado.ToString();
                                        this.lblResultado.Text = stringResultado;
                                        this.lstOperaciones.Items.Add("0");
                                    }
                                    else
                                    {
                                        resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
                                        valor = conversion.DecimalBinario(resultado);
                                        this.lblResultado.Text = valor;
                                        this.lstOperaciones.Items.Add(valor);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Evento que se encarga de llamar al metodo "BinarioDecimal" para transformar un numero binario a decimal
        /// y mostrar la conversion en el formulario (con sus respectivas validaciones).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando conversion = new Operando();
            double resultado;
            string valor;
            string stringResultado;

            if (this.cmbOperador.Text != "")
            {
                if (!double.TryParse(this.txtNumero1.Text, out this.doble) && double.TryParse(this.txtNumero2.Text, out this.doble))
                {
                    resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
                    stringResultado = resultado.ToString();
                    this.lblResultado.Text = stringResultado;
                    this.lstOperaciones.Items.Add("0");
                }
                else
                {
                    if (double.TryParse(this.txtNumero1.Text, out this.doble) && !double.TryParse(this.txtNumero2.Text, out this.doble))
                    {
                        resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
                        stringResultado = resultado.ToString();
                        this.lblResultado.Text = stringResultado;
                        this.lstOperaciones.Items.Add("0");
                    }
                    else
                    {
                        if ((this.txtNumero1.Text.Contains("*") || this.txtNumero1.Text.Contains("+") || this.txtNumero1.Text.Contains("-") || this.txtNumero1.Text.Contains("/")) && !double.TryParse(this.txtNumero2.Text, out this.doble))
                        {
                            resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
                            stringResultado = resultado.ToString();
                            this.lblResultado.Text = stringResultado;
                            this.lstOperaciones.Items.Add("0");
                        }
                        else
                        {
                            if ((this.txtNumero2.Text.Contains("*") || this.txtNumero2.Text.Contains("+") || this.txtNumero2.Text.Contains("-") || this.txtNumero2.Text.Contains("/")) && !double.TryParse(this.txtNumero1.Text, out this.doble))
                            {
                                resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
                                stringResultado = resultado.ToString();
                                this.lblResultado.Text = stringResultado;
                                this.lstOperaciones.Items.Add("0");
                            }
                            else
                            {
                                if (this.txtNumero1.Text.Contains(" ") && this.txtNumero2.Text.Contains(" "))
                                {
                                    resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
                                    stringResultado = resultado.ToString();
                                    this.lblResultado.Text = stringResultado;
                                    this.lstOperaciones.Items.Add("0");
                                }
                                else
                                {
                                    if (!double.TryParse(this.txtNumero1.Text, out this.doble) && !double.TryParse(this.txtNumero2.Text, out this.doble))
                                    {
                                        resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
                                        stringResultado = resultado.ToString();
                                        this.lblResultado.Text = stringResultado;
                                        this.lstOperaciones.Items.Add("0");
                                    }
                                    else
                                    {

                                        resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
                                        valor = conversion.BinarioDecimal(resultado.ToString());
                                        this.lblResultado.Text = valor;
                                        this.lstOperaciones.Items.Add(valor);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
