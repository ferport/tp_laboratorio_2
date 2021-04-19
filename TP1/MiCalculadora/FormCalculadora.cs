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


        public FormCalculadora()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            
        }
            
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero numero = new Numero();
            if (this.lblResultado.Text != "" || this.lblResultado.Text != "0")
            {
                this.lblResultado.Text = numero.BinarioDecimal(this.lblResultado.Text);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void Limpiar()
        {
            this.lblResultado.Text = "";
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperator.Text = "";
        }

        private void bntOperar_Click(object sender, EventArgs e)
        {
            double resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperator.Text);
            string srtResultado = resultado.ToString();

            this.lblResultado.Text = srtResultado;
        }

        private static double Operar(string numero1, string numero2, string operador)
        {

            Numero operando1 = new Numero(numero1);
            Numero operando2 = new Numero(numero2);
            return Calculadora.Operar(operando1, operando2, operador);
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero numero = new Numero();
            if (this.lblResultado.Text != "" || this.lblResultado.Text != "0")
            {
                this.lblResultado.Text = numero.DecimalBinario(this.lblResultado.Text);
            }
        }
    }
}
