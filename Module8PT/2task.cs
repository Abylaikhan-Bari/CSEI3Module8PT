//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Get the current time
//        DateTime currentTime = DateTime.Now;

//        // Define the time range for the discount (8:00 to 12:00)
//        DateTime discountStartTime = DateTime.Today.AddHours(8);
//        DateTime discountEndTime = DateTime.Today.AddHours(12);

//        // Check if the current time is within the discount hours
//        bool isDiscountApplicable = currentTime >= discountStartTime && currentTime <= discountEndTime;

//        // Initialize variables for product prices and total cost
//        decimal product1Price = 10.0m;
//        decimal product2Price = 20.0m;
//        decimal totalCost = 0.0m;

//        // Prompt the user to select products and enter quantities
//        Console.WriteLine("Product Supermarket");
//        Console.WriteLine("1. Product 1 - $10.00");
//        Console.WriteLine("2. Product 2 - $20.00");

//        Console.Write("Enter the product number (1 or 2): ");
//        int productNumber = int.Parse(Console.ReadLine());

//        Console.Write("Enter the quantity: ");
//        int quantity = int.Parse(Console.ReadLine());

//        // Calculate the cost of the selected product
//        switch (productNumber)
//        {
//            case 1:
//                totalCost = product1Price * quantity;
//                break;
//            case 2:
//                totalCost = product2Price * quantity;
//                break;
//            default:
//                Console.WriteLine("Invalid product number.");
//                return;
//        }

//        // Apply the 5% discount if applicable
//        if (isDiscountApplicable)
//        {
//            decimal discountAmount = totalCost * 0.05m;
//            totalCost -= discountAmount;
//        }

//        // Display the total cost
//        Console.WriteLine($"Total cost: ${totalCost:F2}");

//        Console.ReadLine(); // Wait for Enter key to close the program
//    }
//}
