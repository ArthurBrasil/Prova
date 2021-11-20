using _3C1ARTHUR3.Code.DAL;
using _3C1ARTHUR3.Code.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1ARTHUR3.Code.BLL
{
    class CarrinhoBLL
    {
        //Objeto para acesso ao banco de dados
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tbl_Carrinho";


        //O método de inserir recebe os dados via DTO 
        //e envia para o banco de dados através da classe AcessoBancoDados
        public void Inserir(CarrinhoDTO medDto)
        {
            //Antes de criar o comando aqui, teste no PhpMyAdmin ou Worckbench
            string inserir = $"insert into {tabela} values(null,'{medDto.Nome}','{medDto.Quantidade}', '{medDto.Preco}')";
            conexao.ExecutarComando(inserir);
        }

        public void Editar(CarrinhoDTO medDto)
        {
            string editar = $"update {tabela} set nome = '{medDto.Nome}', quantidade = '{medDto.Preco}',preco = '{medDto.Preco}' where id = '{medDto.Id}';";
            conexao.ExecutarComando(editar);
        }
        public void Excluir(CarrinhoDTO medDto)
        {
            string excluir = $"delete from {tabela} where id = '{medDto.Id}';";
            conexao.ExecutarComando(excluir);
        }
        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }
    }
}
