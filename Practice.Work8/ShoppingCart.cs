namespace Practice.Work8;

public class ShoppingCart
{
    private Product[] products;
    private int[] quantities;
    private int itemCount;

    public ShoppingCart()
    {
        products = new Product[10];
        quantities = new int[10];
        itemCount = 0;
    }

    public void AddProduct(Product product, int quantity)
    {
        products[itemCount] = product;
        quantities[itemCount] = quantity;
        itemCount++;
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0.0;
        for (int i = 0; i < itemCount; i++)
        {
            totalCost += products[i].Price * quantities[i];
        }
        return totalCost;
    }
    
    public bool IsDiscountTime()
    {
        DateTime currentTime = DateTime.Now;
        return currentTime.Hour >= 8 && currentTime.Hour < 12;
    }

    public void ApplyDiscount(ref double totalCost)
    {
        double discount = totalCost * 0.05;
        totalCost -= discount;
        Console.WriteLine("Вы получили скидку в размере 5%");
    }

    public  void PrintReceipt(double totalCost)
    {
        Console.WriteLine("Общая стоимость: " + totalCost + " тенге");
    }
}