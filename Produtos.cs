using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12AtividadeProduto
{
    internal class Produtos
    {
        //VARIAVEIS
        public string nome;
        public string descricao;
        public int quantidade;
        public float preço;
        public bool status = true;

        //FUNÇÕES
        public void mostrar ()
        {
            Console.WriteLine($"Nome do Produto {nome}, tem {quantidade},em estoque, custa R$ {preço} e status: {status}");
        }

        public void desativa()
        {
            quantidade = 0;
            status = false;
        }
    }
}
