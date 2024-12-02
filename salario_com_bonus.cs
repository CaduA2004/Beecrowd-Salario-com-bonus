using System; 

class URI {

    static void Main(string[] args) { 

        string nome = Console.ReadLine();
        double salarioFixo = double.Parse(Console.ReadLine());
        double totalVendas = double.Parse(Console.ReadLine());

        double comissao = totalVendas * 0.15;

        double totalReceber = salarioFixo + comissao;

        Console.WriteLine($"TOTAL = R$ {totalReceber:F2}");

    }

}