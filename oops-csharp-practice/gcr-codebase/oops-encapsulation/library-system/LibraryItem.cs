using System;

public abstract class LibraryItem
{
    private int itemId;
    private string title;

    public int ItemId{get=>itemId;set=>itemId=value;}
    public string Title{get=>title;set=>title=value;}

    public abstract int GetDuration();
    public void GetDetails()
    {
        Console.WriteLine(ItemId +" " + Title);
    }
}