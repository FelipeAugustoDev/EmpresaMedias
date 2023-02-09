using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa1
{
    public partial class frmPrincipal : Form
    {
        int CNPJ = 0;

        public frmPrincipal()
        {
            InitializeComponent();
        }



        /// <summary>
        ///  Vetifica se o cnpj foi inserido
        /// </summary>
        /// <returns name="Metodos()"> </returns>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            double valor = 0;
            int estoque = 0;
            double resul = 0;
            if (txbCNPJ.Text.Trim() != "")
            {
                try
                {
                    Informacoes info = new Informacoes(txbNome.Text, double.Parse(txbValor.Text), int.Parse(txbEstoque.Text), int.Parse(txbCNPJ.Text));
                    lboItens.Items.Add(info);
                }
                catch (Exception g)
                {
                    MessageBox.Show(g.Message);
                    return;
                }
            }
            else { return; }

            estoque += int.Parse(txbEstoque.Text);
            valor += double.Parse(txbValor.Text);

            Metodos(estoque, valor);
            


        }
        /// <summary>
        /// Metodo para Média Total
        /// </summary>
        /// <param name="estoque"></param>
        /// <param name="valor"></param>
        private void Metodos(int estoque, double valor)
        {
            double resultado = valor / (double)estoque;
        }

        /// <summary>
        /// Método para média de cnpj
        /// </summary>
        /// <param name="CNPJ"></param>
        public void MetodosCNPJ(int CNPJ)
        {

        }

    }
}
