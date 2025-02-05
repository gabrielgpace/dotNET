namespace ExercicioHerancaPolimorfismo.Entities;

public class UsedProduct : Product
{
    public DateTime ManufacureDate { get; set; }

    public UsedProduct()
    {
        
    }

    public UsedProduct(string name, double price, DateTime manufacureDate) : base(name, price)
    {
        ManufacureDate = manufacureDate;
    }

    public override string PriceTag()
    {
        return base.PriceTag() + $" (used), {ManufacureDate:dd/MM/yyyy}";
    }
}