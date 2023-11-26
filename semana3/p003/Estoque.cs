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
        Console.WriteLine("Produtos cadastrados:\n");
        Console.WriteLine($"Id\t\tNome\t\tQtde\tPreço");
        foreach(Produto p in Products){
            Console.WriteLine($"{p.Id}\t\t{p.Name}\t\t{p.Qty}\t{p.Price}");
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

            Console.WriteLine(p.Name);

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

            Console.WriteLine(p.Name);

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



    public void listProductsByQty(){
        try{

            Console.Write("Quantidade máxima: ");
            int maxQty = int.Parse(Console.ReadLine()!);

            if(maxQty < 0){
                throw new Exception("Quantidade deve ser maior ou igual a zero");
            }

            var products = from p in Products
                           where p.Qty < maxQty
                           select p;

            Console.WriteLine($"Produtos com quantidade abaixo de {maxQty}:");
            Console.WriteLine($"Id\t\tNome\t\tQtde\tPreço");
            foreach(Produto p in products){
                Console.WriteLine($"{p.Id}\t\t{p.Name}\t\t{p.Qty}\t{p.Price}");
            }

        }catch(Exception e){
            Console.WriteLine($"Erro: {e.Message}");
        }
    }

    public void listProductsByPrice(){
        try{

            Console.Write("Preço mínimo: ");
            double minPrice = double.Parse(Console.ReadLine()!);

            if(minPrice < 0){
                throw new Exception("Preço deve ser maior ou igual a zero");
            }

            Console.Write("Preço máximo: ");
            double maxPrice = double.Parse(Console.ReadLine()!);

            if(maxPrice < 0){
                throw new Exception("Preço deve ser maior ou igual a zero");
            }

            var products = from p in Products
                           where p.Price >= minPrice && p.Price <= maxPrice
                           select p;

            Console.WriteLine($"Produtos com preço entre {minPrice} e {maxPrice}:");
            Console.WriteLine($"Id\t\tNome\t\tQtde\tPreço");
            foreach(Produto p in products){
                Console.WriteLine($"{p.Id}\t\t{p.Name}\t\t{p.Qty}\t{p.Price}");
            }

        }catch(Exception e){
            Console.WriteLine($"Erro: {e.Message}");
        }
    }


    public void totalStockValue(){
        try{

            double total = 0;
            foreach(Produto p in Products){
                total += p.Price * p.Qty;
            }

            Console.WriteLine($"Valor total do estoque: {total}");

        }catch(Exception e){
            Console.WriteLine($"Erro: {e.Message}");
        }
    }

    public void totalStockValueByProduct(){
        try{

            Console.WriteLine($"Id\t\tNome\t\tQtde\tPreço\tTotal");
            foreach(Produto p in Products){
                Console.WriteLine($"{p.Id}\t\t{p.Name}\t\t{p.Qty}\t{p.Price}\t{p.Price * p.Qty}");
            }

        }catch(Exception e){
            Console.WriteLine($"Erro: {e.Message}");
        }
    }



}
