using System;
using System.Collections.Generic;

namespace Adiciona_remove_e_muda_produtos.classes
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }
        
        List<Produto> listaDeProdutos = new List<Produto>();
        public void AdicionarProduto(Produto produto){
            listaDeProdutos.Add(produto);
        }
        public void RemoverProduto(Produto produto){
            listaDeProdutos.Remove(produto);
        }

        public void MostrarProdutos(){
            if(listaDeProdutos != null){
                foreach (var item in listaDeProdutos)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"R${item.Preco.ToString("n2")} - Nome {item.Nome}");
                    Console.ResetColor();
                }
            }else{
                Console.WriteLine("Nenhum produto cadastrado");
            }
        }
        public void AlterarItem(int _codigo, Produto _produtoNovo){
            listaDeProdutos.Find(x => x.Codigo == _codigo).Nome = _produtoNovo.Nome;
            listaDeProdutos.Find(x => x.Codigo == _codigo).Preco = _produtoNovo.Preco;
            listaDeProdutos.Find(x => x.Codigo == _codigo).Codigo = _produtoNovo.Codigo;
        }

        //produtoNovo(10, "Pepsi", 4);

        //Alterar(1, produtoNovo);

        //Produto
        //Codigo = 1
        //Nome = Coca
        //Preco = 5
    }
}