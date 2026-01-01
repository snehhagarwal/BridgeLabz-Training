// InvoiceParser.cs - Parses invoice strings and calculates totals
using System;
public class InvoiceParser
{
    // Split invoice string into tasks
    public string[] SplitInv(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return new string[0];
        }
        string[] arr = s.Split(',');
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = arr[i].Trim();
        }
        return arr;
    }

    // Get task name from string
    public string GetTask(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return "";
        }
        int idx = s.IndexOf('-');
        if (idx == -1)
        {
            return s.Trim();
        }
        string name = s.Substring(0, idx).Trim();
        return name;
    }

    // Get amount from string
    public double GetAmt(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }
        int idx = s.IndexOf('-');
        if (idx == -1)
        {
            return ToAmt(s);
        }
        string amt = s.Substring(idx + 1).Trim();
        return ToAmt(amt);
    }

    // Helper: convert string to amount
    private double ToAmt(string s)
    {
        s = s.ToUpper();
        s = s.Replace("INR", "");
        s = s.Replace("₹", "");
        s = s.Replace("$", "");
        s = s.Replace("USD", "");
        s = s.Replace("RS", "");
        s = s.Replace("RUPEES", "");
        s = s.Trim();

        double amt = 0;
        if (double.TryParse(s, out amt))
        {
            return amt;
        }
        else
        {
            return 0;
        }
    }

    // Get total amount
    public double GetTot(string[] arr)
    {
        double tot = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            double amt = GetAmt(arr[i]);
            tot += amt;
        }
        return tot;
    }

    // Get subtotal
    public double GetSub(string[] arr)
    {
        return GetTot(arr);
    }

    // Get tax
    public double GetTax(double sub, double rate = 18.0)
    {
        return sub * rate / 100.0;
    }

    // Get final total
    public double GetFinal(double sub, double rate = 18.0)
    {
        double tx = GetTax(sub, rate);
        return sub + tx;
    }

    // Format currency
    public string FmtCur(double amt, string cur = "INR")
    {
        if (cur == "INR")
        {
            return "₹" + amt.ToString("F2");
        }
        else if (cur == "USD")
        {
            return "$" + amt.ToString("F2");
        }
        else
        {
            return amt.ToString("F2") + " " + cur;
        }
    }

    // Generate invoice number
    public string GenNo()
    {
        DateTime d = DateTime.Now;
        return "INV-" + d.ToString("yyyyMMdd") + "-" + d.ToString("HHmmss");
    }
}
