public  abstract class Veiculo{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public Veiculo (string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }

    public abstract void Ligar();
    public void Desligar()
    {
        Console.WriteLine($"O veículo da marca {Marca} e modelo {Modelo} foi desligado!");
    }

}