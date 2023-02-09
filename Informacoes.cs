using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa1
{


    /// <summary>
    /// Declaração de dados e obter dados
    /// </summary>
    class Informacoes
    {

        private string _nome;
        private double _valor;
        private int _estoque;
        private int _cnpj;

        public string Nome
        {
            get { return _nome; }
        }
        public double Valor
        {
            get { return _valor;}
        }
        public int Estoque
        {
            get { return _estoque; }
        }
        public int CNPJ
        {
            get { return _cnpj; }
        }


        /// <summary>
        /// Sobreescrever os dados que serão implementados nos lboItens
        /// </summary>
        /// <returns name="Nome"></returns>
        /// <returns name="Valor"></returns>
        /// <returns name="Estoque"></returns>
        public override string ToString()
        {
            return _nome +" "+ _valor + " , unid: " + _estoque;
        }

        public Informacoes()
        {

        }


        /// <summary>
        /// Construtor de Objeto para tabela
        /// </summary>
        /// <param name="Nome"></param>
        /// <param name="Valor"></param>
        /// <param name="Estoque"></param>
        /// <param name="CNPJ"></param>
        public Informacoes(string Nome, double Valor, int Estoque, int CNPJ)
        {
            this._nome = Nome;
            this._valor = Valor;
            this._estoque = Estoque;
            this._cnpj = CNPJ;
        }
    }
}
