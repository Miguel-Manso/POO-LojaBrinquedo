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
    public partial class Form2 : Form
    {
        listaExecucao lista = new listaExecucao();

        public Form2()
        {
            InitializeComponent();
        }

        private void AdicionarBrinquedo()
            {

                //Variaveis auxiliares para cada campo
                string cnpj, nome, categoria, idademinima, codbarra, descricao, preco;


                nome = txtNome.Text;
                cnpj = txtCNPJ.Text;
                categoria = txtCategoria.Text;
                idademinima = txtIdadeMinima.Text;
                codbarra = txtCodBarra.Text;
                descricao = txtDescricao.Text;
                preco = txtPreco.Text;


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


                lista.Adicionar(brinquedo);


                //Atualizar a listBox para exibir os registros
                AtualizarLista();

                //Após inserção de dados, limpar os campos
                txtNome.Clear();
                txtCNPJ.Clear();
                txtCategoria.Clear();
                txtIdadeMinima.Clear();
                txtCodBarra.Clear();
                txtDescricao.Clear();
                txtPreco.Clear();

        }

        public void ClasseArmazenar()
        {
            Brinquedo brinquedoSelecionado = lsbListar.SelectedItem as Brinquedo;
        }

        private void RemoverBrinquedo()
            {
                Brinquedo brinquedoSelecionado = lsbListar.SelectedItem as Brinquedo;

                if (brinquedoSelecionado != null)
                {
                    lista.Remover(brinquedoSelecionado);

                    AtualizarLista();
                }
            }

            //Método para atualizar a ListBox
            private void AtualizarLista()
            {
                //Limpar o ListBox
                lsbListar.DataSource = null;

                //Popular a ListBox com a Lista de Usuarios
                lsbListar.DataSource = lista.ListarBrinquedo();
                lsbListar.DisplayMember = "codBarraDescricaoCategorianomeFabricante";


            }

       


        private void label1_Click(object sender, EventArgs e)
            {

            }

            private void btnCriar_Click(object sender, EventArgs e)
            {
               
            }

            private void btnDeletar_Click(object sender, EventArgs e)
            {
                
            }

        private void btnCriar_Click_1(object sender, EventArgs e)
        {
            AdicionarBrinquedo();
        }

        private void btnDeletar_Click_1(object sender, EventArgs e)
        {
            RemoverBrinquedo();
        }

        private void btnVizualizar_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
    }
