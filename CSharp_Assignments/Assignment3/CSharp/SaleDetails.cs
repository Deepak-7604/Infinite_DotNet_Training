using System;

public class SaleDetails
{
    int salesNo;
    int productNo;
    double price;
    int qty;
    double totalAmount;
    DateTime dateOfSale;

    // Constructor
    public SaleDetails(int salesNo, int productNo, double price, int qty, DateTime dateOfSale)
    {
        this.salesNo = salesNo;
        this.productNo = productNo;
        this.price = price;
        this.qty = qty;
        this.dateOfSale = dateOfSale;
    }

   
    public void CalculateTotal()
    {
        totalAmount = qty * price;
    }

    public void ShowData()
    {
        Console.WriteLine("\nSales Details:");
        Console.WriteLine("Sales No: " + salesNo);
        Console.WriteLine("Product No: " + productNo);
        Console.WriteLine("Price: " + price.ToString("F2"));
        Console.WriteLine("Quantity: " + qty);
        Console.WriteLine("Date of Sale: " + dateOfSale.ToShortDateString());
        Console.WriteLine("Total Amount: " + totalAmount.ToString("F2"));
    }
}

// Main Program
class Program
{
    static void Main(string[] args)
    {
        // Creating object using constructor
        SaleDetails s1 = new SaleDetails(1, 101, 500.0, 3, DateTime.Now);

        // Calculate total and show data
        s1.CalculateTotal();
        s1.ShowData();

        Console.ReadLine();
    }
}