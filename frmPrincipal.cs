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
        public void LimparTudo()
        {
            lboMedias.Items.Clear();
        }
        public double Media()
        {
            double medias = 0;
            double soma = 0;
            int qnt = 0;
            foreach (var item in lboItens.Items)
            {
                soma += double.Parse(txbValor.Text);
                qnt++;
            }
            return medias = soma / qnt;
        }
        public double Media(int CNPJ)
        {
            double medias = 0;
            double soma = 0;
            foreach (var item in lboItens.Items)
            {
                soma += double.Parse(txbValor.Text);
                CNPJ++;
            }
            return medias = soma / CNPJ;
        }



        /// <summary>
        ///  Vetifica se o cnpj foi inserido
        /// </summary>
        /// <returns name="Metodos()"> </returns>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbCNPJ.Text.Trim() != "")
            {
                //encaixar o nmr de vezes que o cnpj passou, aqui.
                try
                {
                    Informacoes info = new Informacoes(txbNome.Text, double.Parse(txbValor.Text), int.Parse(txbEstoque.Text), int.Parse(txbCNPJ.Text));
                    lboItens.Items.Add(info);
                    CNPJ++;
                }
                catch (Exception g)
                {
                    MessageBox.Show("Atençao! "+ g.Message, MessageBoxIcon.Exclamation.ToString());
                    return;
                }
            }
            else { return; }



            lboMedias.Items.Add(Media());
            lboMedias.Items.Add(Media(CNPJ));
            //ENCAIXAR O MÉTODO DE MÉDIA DIRETAMENT NO lboMedia


        }
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void lboMedias_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
