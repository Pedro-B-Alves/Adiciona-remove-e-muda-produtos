using System;
using Adiciona_remove_e_muda_produtos.classes;

namespace Adiciona_remove_e_muda_produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool opcao = true;
            bool opcao3 = true;
            Carrinho carrinho = new Carrinho();
            do
            {
                Console.WriteLine("[1]-Adicionar produtos");
                Console.WriteLine("[2]-Ver produtos");
                Console.WriteLine("[0]-Sair");
                string opcao2 = Console.ReadLine();
                switch (opcao2)
                {
                    case "1":
                        Produto produto1 = new Produto(1, "Mouse Razer 3.5", 300);
                        Produto produto2 = new Produto(2, "HeadSet Chroma 7.1", 500);
                        Produto produto3 = new Produto(3, "Mouse Pad XPTO", 120);

                        carrinho.AdicionarProduto(produto1);
                        carrinho.AdicionarProduto(produto2);
                        carrinho.AdicionarProduto(produto3);
                        Console.WriteLine("Mouse Razer 3.5, HeadSet Chroma 7.1 e Mouse Pad XPTO adicionados");

                        Console.WriteLine("Deseja remover algum? s/n");
                        string opcao4 = Console.ReadLine();
                        if (opcao4 == "s"){
                            carrinho.RemoverProduto(produto2); //Aqui eu removo da lista
                            Console.WriteLine($"Produto 2 {produto2.Nome} foi removido");
                        }
                        Console.WriteLine($"Deseja alterar um produto? s/n");
                        string opcao5 = Console.ReadLine();
                        if (opcao5 == "s" && opcao4 != "s")
                        {
                            Produto produtoNovo = new Produto();
                            produtoNovo.Codigo = 20;
                            produtoNovo.Nome = "Fone com microfone Chroma 7.1";
                            produtoNovo.Preco = 600;

                            carrinho.AlterarItem(2, produtoNovo);
                            Console.WriteLine($"O produto foi alterado para {produtoNovo.Nome}");
                        }else{
                            Console.WriteLine("Devido você ter removido um produto não da para alterá-lo");
                        }
                        opcao3 = false;
                        break;
                    case "2":
                        if (opcao3 == true){
                            Console.WriteLine("Você não adicionou produtos");
                        }else{
                            carrinho.MostrarProdutos();
                        }
                        break;
                    case "0":
                        Console.WriteLine("Programa finalizado");
                        opcao = false;
                        break;
                    default:
                        Console.WriteLine("Você digitou uma opção inválida");
                        break;
                }
            } while (opcao != false);
            
        }
    }
}
