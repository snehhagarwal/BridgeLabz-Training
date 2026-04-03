using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int rodLength=8;
        Rod rod=new Rod(rodLength);
        PriceChart chart=new PriceChart(rodLength);
        RodCutter cutter=new RodCutter();
        RevenueReport report=new RevenueReport();

        chart.Add(1,1);
        chart.Add(2,5);
        chart.Add(3,8);
        chart.Add(4,9);
        chart.Add(5,10);
        chart.Add(6,17);
        chart.Add(7,17);
        chart.Add(8,20);

        int optimizeRevenue=cutter.Maximize(rod,chart);
        report.Print("Scenario A: ",optimizeRevenue);

        chart.Add(3,12);
        int customRevenue=cutter.Maximize(rod,chart);
        report.Print("Scenario B: ",customRevenue);

        int nonOptimized=cutter.NonOptimize(rod,chart);
        report.Print("Scenario C: ",nonOptimized);

        Console.ReadLine();
    }
}