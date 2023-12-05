using atvHeranca;

class Program
{
    public static void Main(string[] args)
    {
        Utilitario util = new Utilitario();
        util.marca = "Chevrolet";
        util.modelo = "2012";
        util.quantLugares = 4;
        util.cor = "Vermelho";
        util.valor = 5000;

        Trabalho trab = new Trabalho();
        trab.marca = "Volkswagen";
        trab.modelo = "2022";
        trab.capPeso = 2000;
        trab.quantEixos = 8;
        trab.valor = 10000;


        Console.WriteLine("Marca: " + util.marca + " Modelo: " + util.modelo + " Quantidade: " + util.quantLugares + " Cor: " + util.cor);
        Console.WriteLine(" Valor: " + util.desconto());

        Console.WriteLine("---------------------------Trabalho---------------------------------------");
        Console.WriteLine("Marca: " + trab.marca + " Modelo: " + trab.modelo + " Capacidade de peso: " + trab.capPeso
            + " Quantidade de Eixo: " + trab.quantEixos);
        Console.WriteLine(" Valor: " + trab.desconto());
    }
}
