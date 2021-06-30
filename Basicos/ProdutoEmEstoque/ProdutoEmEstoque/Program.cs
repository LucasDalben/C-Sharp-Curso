using System;

namespace ProdutoEmEstoque {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.WriteLine("Nome: ");
            p.Nome = Console.ReadLine();

            Console.WriteLine("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Preço: ");
            p.Preco = float.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: {p} \n");

            Console.WriteLine($"Digite quantos produtos serão adicionados a lista: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);

            Console.WriteLine($"\n Dados atualizados: {p}");

            Console.WriteLine($"Digite quantos produtos serão removidos: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);

            Console.WriteLine($"\n Dados atualizados: {p}");
        }
    }
}
