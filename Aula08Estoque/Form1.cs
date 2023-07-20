namespace Aula08Estoque
{
    public partial class Form1 : Form
    {
        List<string> produtoNome = new List<string>();
        List<int> produtoQuantidade = new List<int>();   
        Utilidades utilidades= new Utilidades();

        public Form1()
        {
            InitializeComponent();
        }

        void adicionaProduto()
        {
            if (utilidades.textBoxEstaVazio(txtNome)==true)
            {
                MessageBox.Show("O nome está vazio!!!");
                return;
            }
            if (utilidades.textBoxEstaVazio(txtQuantidade)==true)
            {
                MessageBox.Show("a quantidade está Vazia!!!");
                return;
            }
            string nome = txtNome.Text;
            int quantidade = int.Parse(txtQuantidade.Text);
            produtoNome.Add(nome);
            produtoQuantidade.Add(quantidade);
        }

        void atualizaInterface()
        {
            //conta quantidade cadastrada
            int quantidadeCadastrada = produtoNome.Count();
            lblCadastro.Text = quantidadeCadastrada.ToString();

            //conta todos os produtos em estoque
            int estoque = 0;
            for(int i = 0; i <produtoQuantidade.Count(); i++)
            {
                int quantidade = produtoQuantidade[i];
                estoque += quantidade;
            }
            lblEstoque.Text = estoque.ToString();
        }

        void limpaCampos()
        {
            txtNome.Clear();
            txtQuantidade.Clear(); 
            txtNome.Focus();
        }

        void verProduto(bool primeiro)
        {
            if(listaVazia()==true)
            {
                MessageBox.Show("Você não pode ver a lista ainda...");
                return;
            }


            string nome; 
            int quantidade;

            if (primeiro == true)
            {
                nome = produtoNome[0];
                quantidade = produtoQuantidade[0];
            }
            else
            {
                nome = produtoNome[produtoNome.Count()-1];
                quantidade = produtoQuantidade[produtoQuantidade.Count()-1];
            }
            MessageBox.Show($"Nome: {nome}, Quantidade: {quantidade}");
        }

        void remove()
        {
            if (listaVazia() == true)
            {
                MessageBox.Show("Não tem nenhum item para remover!!");
            }
            else
            {
               produtoNome.RemoveAt(0);
               produtoQuantidade.RemoveAt(0);
            }
        }

        bool listaVazia()
        {
            if(produtoNome.Count() > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

            //botão

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            adicionaProduto();
            atualizaInterface();
            limpaCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void btnPrimeiroProduto_Click(object sender, EventArgs e)
        {
            verProduto(true);
        }

        private void btnUltimoProduto_Click(object sender, EventArgs e)
        {
            verProduto(false);
        }

        private void btnDeletarPrimeiroProduto_Click(object sender, EventArgs e)
        {
            remove();
            atualizaInterface();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utilidades utilidades= new Utilidades();
            utilidades.mostraMensagem();
        }
    }
}