using System;

namespace GeraEstoque; // Note: actual namespace depends on the project name.

    public class Menu{

    public static void Menu2()
    {

            Console.Clear();
            ShowOptions();

            var option = short.Parse(Console.ReadLine());


        switch (option)
        {
            case 1: CadastrarProduto(); break; //Editor.Start(); break;
            case 2:  Menu2(); break;
            case 3: Menu2(); break;
            case 4: Menu2(); break;
            case 0:  Console.Clear(); Environment.Exit(0); break;
            default: Menu2(); break;
        }

    }

    static void ShowOptions()
    {

        Console.WriteLine("Seja bem vindo ao GeraEstoque 1.0");

        Console.WriteLine("----------------------------------");

        Console.WriteLine("1 - Cadastrar produto");
     
        Console.WriteLine("2 - Consultar produto");

        Console.WriteLine("3 - Modificar produto");

        Console.WriteLine("4 - Excluir produto");

        Console.WriteLine("0 - Sair");

        Console.WriteLine("Digite a opção:");
    }

    static void CadastrarProduto()
    {
        Guid ID = Guid.NewGuid();
        System.Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();
        System.Console.WriteLine("Digite a quantidade em estoque:");
        var qtdEstoque = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Digite valor da Compra:");
        var valorCompra = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Digite o valor da venda:");
        var valorVenda = int.Parse(Console.ReadLine());

        

        System.Console.WriteLine("Produto Cadastrado com sucesso!");
        System.Console.WriteLine("Seu ID: "+ ID);
        System.Console.WriteLine("Nome: "+ nome);
        System.Console.WriteLine("Qtd: "+ qtdEstoque);
        System.Console.WriteLine("R$ Compra: "+ valorCompra);
        System.Console.WriteLine("R$ Venda: "+ valorVenda);

        
        System.Console.WriteLine("Precione qualquer tecla para retornar ao menu");
        var option2 = (Console.ReadLine());
        if(string.IsNullOrEmpty(option2)){
            option2 = "0";
        }
        switch (option2)
        {
            case "4":  Menu2(); break;

            default: Menu2(); break;
        }
        
        
        Environment.Exit(0);
    }
}