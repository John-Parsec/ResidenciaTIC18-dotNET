using semana3.p003;

public class Estoque{
    public List<Produto> Products { get; }

    public Estoque(){
        Products = new List<Produto>();
    }

    public void addProduct(Produto product){
        Products.Add(product);
    }

    public void addProduct(string name, double unitPrice, int quantity = 0){
        Products.Add(new Produto(name, unitPrice, quantity));
    }

    public void addProduct(){
        try{
            Console.Write("Nome do produto: ");
            string name = Console.ReadLine()!;

            Console.Write("Preço unitário: ");
            double unitPrice = double.Parse(Console.ReadLine()!);

            if(unitPrice <= 0){
                throw new Exception("Preço unitário deve ser maior que zero");
            }
            
            Console.Write("Quantidade: ");
            int quantity = int.Parse(Console.ReadLine()!);

            if(quantity < 0){
                throw new Exception("Quantidade deve ser maior ou igual a zero");
            }

            Products.Add(new Produto(name, unitPrice, quantity));

        }catch(Exception e){
            Console.WriteLine($"Erro: {e.Message}");
        }
    }

    public void listProducts(){
        Console.WriteLine("Produtos cadastrados:");
        foreach(Produto p in Products){
            Console.WriteLine(p);
        }
    }

    public void productById(){
        try{
            Console.Write("Id do produto: ");
            int id = int.Parse(Console.ReadLine()!);

            Produto? p = Products.Find(p => p.Id == id);

            if(p == null){
                throw new Exception("Produto não encontrado");
            }

            Console.WriteLine(p);

        }catch(Exception e){
            Console.WriteLine($"Erro: {e.Message}");
        }
    }

    public void productById(int id){
        try{
            Produto? p = Products.Find(p => p.Id == id);

            if(p == null){
                throw new Exception("Produto não encontrado");
            }

            Console.WriteLine(p);

        }catch(Exception e){
            Console.WriteLine($"Erro: {e.Message}");
        }
    }

    public Produto getProductById(){
        try{
            Console.Write("Id do produto: ");
            int id = int.Parse(Console.ReadLine()!);

            Produto? p = Products.Find(p => p.Id == id);

            if(p == null){
                throw new Exception("Produto não encontrado");
            }

            return p;

        }catch(Exception e){
            Console.WriteLine($"Erro: {e.Message}");
            return null;
        }
    }

    public Produto getProductById(int id){
        try{
            Produto? p = Products.Find(p => p.Id == id);

            if(p == null){
                throw new Exception("Produto não encontrado");
            }

            return p;

        }catch(Exception e){
            Console.WriteLine($"Erro: {e.Message}");
            return null;
        }
    }


    public void updateQty(int id, int fluxo){
        try{
            
            Produto? p = Products.Find(p => p.Id == id);

            if(p == null){
                throw new Exception("Produto não encontrado");
            }

            if(p.Qty + fluxo < 0){
                throw new Exception("Quantidade não pode ser negativa");
            }

            p.Qty += fluxo;

        }catch(Exception e){
            Console.WriteLine($"Erro: {e.Message}");
        }
    }

    public void updateQty(){
        try{
            Console.Write("Id do produto: ");
            int id = int.Parse(Console.ReadLine()!);

            Console.Write("Quantidade: ");
            int fluxo = int.Parse(Console.ReadLine()!);
            
            Produto? p = Products.Find(p => p.Id == id);

            if(p == null){
                throw new Exception("Produto não encontrado");
            }

            if(p.Qty + fluxo < 0){
                throw new Exception("Quantidade não pode ser negativa");
            }

            p.Qty += fluxo;

        }catch(Exception e){
            Console.WriteLine($"Erro: {e.Message}");
        }
    }


    
}
