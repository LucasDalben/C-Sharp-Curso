using System;
using System.Collections.Generic;
using System.Text;

namespace ProdutoEmEstoque {
    class Produto {
        public string Nome;
        public int Quantidade;
        public float Preco;
        public float ValorEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade) {
            Quantidade -= quantidade;
        }
        public override string ToString() {
            return $"{Nome}, valor ${Preco.ToString("F2")}," +
                   $"{Quantidade} unidades, total: $" +
                   $"{ValorEmEstoque().ToString("F2")}";
        }
    }
}
