using System;

class Program
{
    static void Main(string[] args)
    {
        int n=12;
        WoodenRod rod=new WoodenRod(n);
        PriceTable table=new PriceTable(n);
        CutterLogic cutter=new CutterLogic();
        Report report=new Report();

        table.SetPrice(1,2);
        table.SetPrice(2,5);
        table.SetPrice(3,7);
        table.SetPrice(4,9);
        table.SetPrice(5,10);
        table.SetPrice(6,17);
        table.SetPrice(7,17);
        table.SetPrice(8,20);
        table.SetPrice(9,24);
        table.SetPrice(10,30);
        table.SetPrice(11,32);
        table.SetPrice(12,35);

        int maxRevenue=cutter.MaxRevenue(rod,table);
        report.Print("Scenario A: ",maxRevenue);

        int revenueWaste=cutter.MaxWithWaste(rod,table,2);
        report.Print("Scenario B: ",revenueWaste);

        cutter.Suggest(rod,table);
    }
}