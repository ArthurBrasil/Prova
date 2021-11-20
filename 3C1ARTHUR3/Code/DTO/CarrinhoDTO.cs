using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1ARTHUR3.Code.DTO
{
    class CarrinhoDTO
    {
        private int _id;
        private string _nome;
        private double _quantidade, _preco;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public double Quantidade { get => _quantidade; set => _quantidade = value; }
        public double Preco { get => _preco; set => _preco = value; }
    }
}
