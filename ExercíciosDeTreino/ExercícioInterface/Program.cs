class Program
{
    static void Main(string[] args)
    {
        // Criando instâncias de Carro e Moto
        IVeiculo veiculo1 = new Carro();
        IVeiculo veiculo2 = new Moto();

        // Chamando métodos dos veículos
        veiculo1.Ligar();
        veiculo1.Desligar();

        veiculo2.Ligar();
        veiculo2.Desligar();
    }
}