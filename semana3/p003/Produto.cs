namespace semana3.p003;

public class Produto{
    private static int ProductId { get; set; } = 2023000;
    public int Id { get; }
    public string? Name { get; private set; }
    public int Qty { get; set; }
    public double Price { get; private set; }


    public Produto(string name, double unitPrice, int quantity = 0){
        this.Id = ++ProductId;
        this.Name = name;
        this.Price = unitPrice;
        this.Qty = quantity;
    }    
}
