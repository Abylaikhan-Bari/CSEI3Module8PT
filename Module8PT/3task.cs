//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] months = { 1, 2, 3, 4, 5 }; // Month numbers
//        double[] sales = { 1000, 1100, 1200, 1300, 1400 }; // Sales data for the past five months

//        // Calculate required sums
//        int N = months.Length;
//        double sumX = 0, sumY = 0, sumXY = 0, sumX2 = 0;

//        for (int i = 0; i < N; i++)
//        {
//            sumX += months[i];
//            sumY += sales[i];
//            sumXY += months[i] * sales[i];
//            sumX2 += months[i] * months[i];
//        }

//        // Calculate the slope (b) and intercept (a) for the linear regression
//        double b = (N * sumXY - sumX * sumY) / (N * sumX2 - sumX * sumX);
//        double a = (sumY - b * sumX) / N;

//        Console.WriteLine($"Linear Regression Equation: Y = {a} + {b} * X");

//        // Predict sales for the next three months (months 6, 7, and 8)
//        for (int month = 6; month <= 8; month++)
//        {
//            double predictedSales = a + b * month;
//            Console.WriteLine($"Month {month}: Predicted Sales = {predictedSales}");
//        }
//    }
//}
