namespace ExercicioHerancaPolimorfismo.Entities;

public class ImportedProduct : Product
{
    public double CustomsFee { get; set; }

    public ImportedProduct()
    {
        
    }

    public ImportedProduct(string name,double price, double customsFee) : base(name, price)
    {
        CustomsFee = customsFee;
    }

    public override string PriceTag()
    {
        return base.PriceTag() + ", Customs Fee: " + CustomsFee;
    }

    public double TotalPrice()
    {
        return Price + CustomsFee;
    }

    
    
}