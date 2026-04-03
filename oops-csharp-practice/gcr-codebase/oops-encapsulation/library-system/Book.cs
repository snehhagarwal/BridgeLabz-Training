using System;

public class Book: LibraryItem
{
    public override int GetDuration()
    {
        return 15;
    }
}