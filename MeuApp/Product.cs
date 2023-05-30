namespace MeuApp;
struct Product
{
    public Product(int id, string name, double price, EProductType type)
    {
        Id = id;
        Name = name;
        Price = price;
        Type = type;
    }

    public int Id;
    public string Name;
    public double Price;
    public EProductType Type;

    public double PriceInDolar(double dolar)
    {
        return Price * dolar;
    }
}