using System;

class ProfitLoss{
    static void Main(string[] args){

        //cost price
        double costPrice= 129;

        //selling price
        double sellingPrice= 191;

        //calculate the profit 
        double profit = sellingPrice - costPrice;

        //calculate the profit percentage
        double profitPercent = (profit/costPrice) * 100;

        Console.WriteLine("The Cost Price is INR " + costPrice + " and Selling Price is INR " + sellingPrice);
        Console.WriteLine("The Profit is INR " + profit + " and the profit percentage is " + profitPercent);
        
    }
}