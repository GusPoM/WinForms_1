using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace prjct_winforms
{
    public partial class frmCalculadora : Form
    {
        double numero1, numero2;
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void txbNumeroUm_TextChanged(object sender, EventArgs e)
        {
            if(txbNumeroUm.Text.Length>0)
            {
                try
                {
                    numero1 = double.Parse(txbNumeroUm.Text);
                }
                catch (FormatException)
                {
                    if (txbNumeroUm.Text != "")
                    {
                        MessageBox.Show("por favor, insira valores válidos (apenas números)");
                        txbNumeroUm.Text = "";
                    }
                }
            }
        }

        private void txbNumeroDois_TextChanged(object sender, EventArgs e)
        {
            try
            {
                numero2 = double.Parse(txbNumeroDois.Text);
            }
            catch (FormatException)
            {
                if (txbNumeroDois.Text != "")
                {
                    MessageBox.Show("por favor, insira valores válidos (apenas números)");
                    txbNumeroDois.Text = "";
                }
            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            string resultado = "";
            resultado = (numero1 + numero2).ToString();
            AtualizarResultado(resultado);
        }
        

        private void btnMenos_Click(object sender, EventArgs e)
        {
            string resultado = "";
            resultado = (numero1 - numero2).ToString();
            AtualizarResultado(resultado);
        }
        private void btnVezes_Click(object sender, EventArgs e)
        {
            string resultado = "";
            resultado = (numero1 * numero2).ToString();
            AtualizarResultado(resultado);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            string resultado = "";
            if (numero2 != 0)
            {
                resultado = (numero1 / numero2).ToString();
            }
            else
            {
                MessageBox.Show("Não é possível dividir um número por 0");
            }
            AtualizarResultado(resultado);
        }

        private void btnCompara_Click(object sender, EventArgs e)
        {
            string resultado = "";
            if (numero1 == numero2)
            {
                resultado = "os dois números apresentados são o mesmo";

            }
            else if (numero1 > numero2)
            {
                resultado = $"{numero1} é maior que {numero2}";
            }
            else
            {
                resultado = $"{numero2} é maior que {numero1}";
                lblResultado.Text = resultado;
            }
            AtualizarResultado(resultado);
        }

        private void btnImparPar_Click(object sender, EventArgs e)
        {
            string resultado = "";
            if ((numero1 + numero2) % 2 == 0)
            {
                if (numero1 % 2 == 0)
                {
                    resultado = $"tanto {numero1} quanto {numero2} são pares";
                }
                else
                {
                    resultado = $"tanto {numero1} quanto {numero2} são impares";
                }
            }
            else
            {
                if (numero1 % 2 == 0)
                {
                    resultado = $"{numero1} é par, já ";
                }
                else
                {
                    resultado = $"{numero1} é impar, já ";
                }

                if (numero2 % 2 == 0)
                {
                    resultado += $"{numero2} é par";
                }
                else
                {
                    resultado += $"{numero2} é impar";
                }
            }
            AtualizarResultado(resultado);
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            string resultado = "";
            txbNumeroUm.Text = "Ponha aqui o primeiro número";
            txbNumeroDois.Text = "Ponha aqui o segundo número";
            resultado = "?";
            AtualizarResultado(resultado);
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {
            
        }

        private void AtualizarResultado(string resultado)
        {
            double teste;
            if (txbNumeroUm.Text.Length > 0)
            {
                try
                {
                    teste = double.Parse(resultado);
                    lblResultado.Text = resultado;
                }
                catch (FormatException)
                {
                    if (txbNumeroUm.Text != "")
                    {
                        MessageBox.Show("por favor, insira valores válidos (apenas números)");
                    }
                }
            }
        }

    }
}
