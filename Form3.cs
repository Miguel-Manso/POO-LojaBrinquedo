using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrinquedoNOVO
{
    public partial class Form3 : Form
    {
        listaExecucao lista = new listaExecucao();

        public Form3()
        {
            InitializeComponent();
        }

        private void ExibirUsuario()
        {
            string cnpj, nome, categoria, idademinima, codbarra, descricao, preco;


            nome = VtxtNome.Text;
            cnpj = VtxtCNPJ.Text;
            categoria = VtxtCategoria.Text;
            idademinima = VtxtIdadeMinima.Text;
            codbarra = VtxtCodBarra.Text;
            descricao = VtxtDescricao.Text;
            preco = VtxtPreco.Text;

            //Criamos a instancia das classes
            Fabricante fabricante = new Fabricante();
            Produto produto = new Produto();
            Brinquedo brinquedo = new Brinquedo();

            //Popular o objeto Fabricante
            fabricante.Nome = nome;
            fabricante.CNPJ = cnpj;


            //Popular o objeto Produto
            produto.codBarra = codbarra;
            produto.Descricao = descricao;
            produto.Fabricante = fabricante;
            produto.Preco = preco;

            //Popular o objeto Brinquedo
            brinquedo.Categoria = categoria;
            brinquedo.idadeMinima = idademinima;
            brinquedo.Produto = produto;
            brinquedo.Fabricante = fabricante;

       

           
        }
    }
}
