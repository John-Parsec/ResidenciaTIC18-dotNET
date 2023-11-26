using semana3.p003;

public class Program{
    public static void Main(string[] args){
        Estoque stock = new Estoque();

        stock.addProduct("Arroz", 10.5, 100);
        stock.addProduct("Feijão", 5.5, 50);
        stock.addProduct("Farinha", 4.5, 200);
        stock.addProduct("Açúcar", 3.5, 150);
        stock.addProduct("Sal", 2.5, 300);

        stock.listProducts();


        Console.WriteLine("\nAdicionando produto pelo console:");
        stock.addProduct();

        Console.WriteLine();
        stock.listProducts();

        Console.WriteLine();
        stock.productById();

        Console.WriteLine();
        stock.listProductsByQty();

        Console.WriteLine();
        stock.listProductsByPrice();

        Console.WriteLine();
        stock.totalStockValue();

        Console.WriteLine();
        stock.totalStockValueByProduct();
    }
}

