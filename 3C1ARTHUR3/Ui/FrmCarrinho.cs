using _3C1ARTHUR3.Code.BLL;
using _3C1ARTHUR3.Code.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3C1ARTHUR3.Ui
{
    public partial class FrmCarrinho : Form
    {
        //Criação dos objetos que acessam a camada de negócio
        CarrinhoBLL medbll = new CarrinhoBLL();
        CarrinhoDTO meddto = new CarrinhoDTO();

        public FrmCarrinho()
        {
            InitializeComponent();
        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto 
            meddto.Nome = txtNome.Text;
            meddto.Quantidade = double.Parse( txtQuantidade.Text);
            meddto.Preco = double.Parse(txtPreco.Text);

            //Envio do dto preenchido para o método inserir
            medbll.Inserir(meddto);

            //mensagem de cadastrado 
            MessageBox.Show("Cadastrado com sucesso!", "sorvetes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = medbll.Listar();
            //limpar campos
            txtId.Clear();
            txtNome.Clear();
            txtQuantidade.Clear();
            txtPreco.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto 
            meddto.Id = int.Parse(txtId.Text);
            meddto.Nome = txtNome.Text;
            meddto.Quantidade = double.Parse(txtQuantidade.Text);
            meddto.Preco = double.Parse(txtPreco.Text);

            //Envio do dto preenchido para o método inserir
            medbll.Editar(meddto);

            //mensagem de cadastrado 
            MessageBox.Show("Cadastrado com sucesso!", "sorvetes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = medbll.Listar();
            //limpar campos
            txtId.Clear();
            txtNome.Clear();
            txtQuantidade.Clear();
            txtPreco.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto 
            meddto.Id = int.Parse(txtId.Text);
            meddto.Nome = txtNome.Text;
            meddto.Quantidade = double.Parse(txtQuantidade.Text);
            meddto.Preco = double.Parse(txtPreco.Text);

            //Envio do dto preenchido para o método inserir
            medbll.Excluir(meddto);

            //mensagem de cadastrado 
            MessageBox.Show("Cadastrado com sucesso!", "sorvetes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = medbll.Listar();
            //limpar campos
            txtId.Clear();
            txtNome.Clear();
            txtQuantidade.Clear();
            txtPreco.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtQuantidade.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPreco.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
