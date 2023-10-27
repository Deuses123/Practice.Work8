using Practice.Work8;


//Task 1
var arr = new RangeOfArray(6, 10)
{
    [6] = 42,
    [7] = 100,
    [10] = 55
};

Console.WriteLine(arr[6]); 
Console.WriteLine(arr[7]); 
Console.WriteLine(arr[10]);


//Task 2
Console.WriteLine("Задача #2");
Product[] availableProducts = {
    new ("Молоко", 2300.0),
    new ("Колбаса", 1000.0),
    new ("Кола", 500.0),
    new ("Энергетик", 400.0)
};

var cart = new ShoppingCart();

foreach (var product in availableProducts)
{
    Console.Write(product.Name + " (цена: " + product.Price + " руб.): ");
    var quantity = int.Parse(Console.ReadLine() ?? string.Empty);
    cart.AddProduct(product, quantity);
    
    
    var totalCost = cart.CalculateTotalCost();

    var isDiscountTime = cart.IsDiscountTime();
    if (isDiscountTime)
    {
        cart.ApplyDiscount(ref totalCost);
    }

    cart.PrintReceipt(totalCost);
}



//Task 3
Console.WriteLine("Задача #3");
var months = 5;
var salesData = new SalesData(months)
{
    [1] = 100, // Январь
    [2] = 150, // Февраль
    [3] = 200, // Март
    [4] = 250, // Апрель
    [5] = 300 // Май
};

// Прогноз на следующие три месяца
double a, b;
salesData.CalculateRegressionCoefficients(salesData, out a, out b);

int nextMonth = salesData.MonthCount + 1;
double nextSales = a * nextMonth + b;

Console.WriteLine($"Прогноз объема продаж на следующий месяц ({nextMonth}): {nextSales} Тенге.");