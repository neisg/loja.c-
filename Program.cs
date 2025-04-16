class Program
{
    public Program()
    {
    }
}

struct Produto
{
    public string nome { get; set; }
    public float preco { get; set; }
    public float peso { get; set; }
    public string marca { get; set; }
    public Produto(string nome, float preco, float peso, string marca)

    {
        this.nome = nome;
        this.preco = preco;
        this.peso = peso;
        this.marca = marca;
    }
  
    

    public void ExibirProduto()
    {
        Console.WriteLine($"Produto: {nome}, Preço: {preco}, Peso: {peso}, Marca: {marca}");
    }

    static void Main(string[] args)   
    {  
        Produto produto1 = new Produto("Arroz", 20.50f, 5.0f, "Tio João");
        Produto produto2 = new Produto("Feijão", 10.00f, 2.0f, "Camil");
        Produto produto3 = new Produto("Macarrão", 5.00f, 1.0f, "Barilla");

        Console.WriteLine($"Produto: {produto1.nome}, Preço: {produto1.preco}, Peso: {produto1.peso}, Marca: {produto1.marca}");
        Console.WriteLine($"Produto: {produto2.nome}, Preço: {produto2.preco}, Peso: {produto2.peso}, Marca: {produto2.marca}");
        Console.WriteLine($"Produto: {produto3.nome}, Preço: {produto3.preco}, Peso: {produto3.peso}, Marca: {produto3.marca}");
        Console.WriteLine("Exibindo produtos:");
        Console.WriteLine("Arroz.nome");
        Console.WriteLine("Feijão.nome");
        Console.WriteLine("Macarrão.nome");

    
    }  
}
