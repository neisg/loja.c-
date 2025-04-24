using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

struct Produto
{
    public string nome;
    public float preco;
    public float peso;
    public string marca;

    public Produto(string nome, float preco, float peso, string marca)
    {
        this.nome = nome;
        this.preco = preco;
        this.peso = peso;
        this.marca = marca;
    }

    public void ExibirProduto()
    {
        Console.WriteLine($"Produto: {nome}, Preço: R$ {preco}, Peso: {peso}kg, Marca: {marca}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        StreamWriter escritor = File.AppendText("teste.txt");
        escritor.WriteLine("Victor");
        escritor.WriteLine("Lima");
        escritor.WriteLine("Curso de C#");
        escritor.Close();
        Console.WriteLine("Arquivo criado com sucesso!");
        Console.ReadLine();


        // Lista de clientes
        List<string> clientes = new List<string> { "João", "Maria", "José", "Ana", "Pedro" };

        // Lista de produtos
        List<Produto> produtos = new List<Produto>
        {
            new Produto("Arroz", 20.50f, 5.0f, "Tio João"),
            new Produto("Feijão", 10.00f, 2.0f, "Camil"),
            new Produto("Macarrão", 5.00f, 1.0f, "Barilla")
        };

        // Imprimindo produtos
        Console.WriteLine("Produtos:");
        foreach (var p in produtos)
        {
            p.ExibirProduto();
        }

        Console.WriteLine();

        // Imprimindo clientes
        Console.WriteLine("Clientes:");
        foreach (var c in clientes)
        {
            Console.WriteLine(c);
        }

        Console.WriteLine();

        // Acessando elementos específicos
        Console.WriteLine("Cliente 3: " + clientes[2]);
        Console.WriteLine("Produto 1: " + produtos[2].nome);
    }
}