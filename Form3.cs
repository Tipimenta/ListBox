using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CestasDaPrima
{

    public partial class Form3 : Form
    {


        List<Produto> lista_produtos = new List<Produto>
        {
            new Produto {Id = 1, Nome = "Café", Preco = 2.5m},
            new Produto {Id = 2, Nome = "Pão", Preco = 4.0m},
            new Produto {Id = 3, Nome = "Leite", Preco = 3.0m},
            new Produto {Id = 4, Nome = "Cereal", Preco = 5.5m},
            new Produto {Id = 5, Nome = "Frutas", Preco = 6.8m},
            new Produto {Id = 6, Nome = "Iogurte", Preco = 3.2m},
            new Produto {Id = 7, Nome = "Ovos", Preco = 7.5m},
            new Produto {Id = 8, Nome = "Queijo", Preco = 5.0m},
            new Produto {Id = 9, Nome = "Manteiga", Preco = 2.0m},
            new Produto {Id = 10, Nome = "Geleia", Preco = 4.5m},
            new Produto {Id = 11, Nome = "Croissant", Preco = 3.8m},
            new Produto {Id = 12, Nome = "Suco de Laranja", Preco = 4.9m},
            new Produto {Id = 13, Nome = "Panquecas", Preco = 6.2m},
            new Produto {Id = 14, Nome = "Granola", Preco = 5.7m},
            new Produto {Id = 15, Nome = "Café com Leite", Preco = 3.7m},
            new Produto {Id = 16, Nome = "Waffles", Preco = 4.5m},
            new Produto {Id = 17, Nome = "Torrada", Preco = 2.0m},
            new Produto {Id = 18, Nome = "Presunto", Preco = 5.3m},
            new Produto {Id = 19, Nome = "Cappuccino", Preco = 4.2m},
            new Produto {Id = 20, Nome = "Smoothie", Preco = 6.5m},
            new Produto {Id = 21, Nome = "Bolo de Café", Preco = 8.0m},
            new Produto {Id = 22, Nome = "Cuscuz", Preco = 3.4m},
            new Produto {Id = 23, Nome = "Muffin", Preco = 2.8m},
            new Produto {Id = 24, Nome = "Aveia", Preco = 4.3m},
            new Produto {Id = 25, Nome = "Sanduíche de Bacon e Ovo", Preco = 7.8m},
            new Produto {Id = 26, Nome = "Chá", Preco = 2.3m},
            new Produto {Id = 27, Nome = "Batata Doce Assada", Preco = 5.1m},
            new Produto {Id = 28, Nome = "Mel", Preco = 3.5m},
            new Produto {Id = 29, Nome = "Salada de Frutas", Preco = 6.0m},
            new Produto {Id = 30, Nome = "Pão de Banana", Preco = 4.7m}
        };


        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            configuraListView();
        }
            

        void configuraListView() 
        {
            lsvItens.View = View.Details;
            lsvItens.Columns.Add("ID");
            lsvItens.Columns.Add("Nome");
            lsvItens.Columns.Add("Preço");
            AtualizaListView(); //chama a função para atulizar o listview
        }

        void AtualizaListView() //recebe cada produto por paramentro
        {
            // Limpa os itens da lista
            lsvItens.Items.Clear();

            // Percorre os itens da lista, adicionando no list View
            foreach (Produto produto in lista_produtos)
            {
                AdicionarItemListView(produto);
            }
        }

        void AdicionarItemListView(Produto produto)
        {
            ListViewItem item = new ListViewItem(produto.Id.ToString());
            item.SubItems.Add(produto.Nome);
            item.SubItems.Add(produto.Preco.ToString("c"));

            lsvItens.Items.Add(item);          
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Produto produto;

            produto.Id = 1;
            produto.Nome = "Chocolate";
            produto.Preco = 19.9m;

            AdicionarItemListView(produto);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
           // Pega os itens selecionados de um ListView
            //SelectedListViewItemCollection itens = lsvItens.SelectedItems;

            // Percorre cada item selecionado no ListView
            foreach (ListViewItem item in lsvItens.SelectedItems)
            {
                int id = int.Parse(item.Text);

                Produto produto = lista_produtos.Find(prod => prod.Id == id);

                lista_produtos.Remove(produto);
            }

            AtualizaListView();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {


            foreach (ListViewItem item in lsvItens.SelectedItems)
            {
                int id = int.Parse(item.Text);

                Produto produto = lista_produtos.Find(prod => prod.Id == id);
                int index = lista_produtos.IndexOf(produto);

                textId.Text = produto.Id;
                textNome.Text = produto.Nome;
                textPreco.Text = produto.Preco.ToString();
             }

            btnEditar.Visible = false;
            btnSalvar.Visible = true;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            
                int id = 

                Produto produto = lista_produtos.Find(prod => prod.Id == id);

                produto.Nome = textNome.Text;
                produto.Preco = decimal.Parse(textPreco.Text); 

               
                lista_produtos = produto.Nome;  
                item.SubItems[2].Text = produto.Preco.ToString("c");

            }

            
            btnEditar.Visible = true;
            btnSalvar.Visible = false;
        }
    }
}
