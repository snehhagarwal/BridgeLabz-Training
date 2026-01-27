using System;

public class DuplicateContactException : Exception{
    public DuplicateContactException(string message) : base(message) { }
}

public class AddressBookNotFoundException : Exception{
    public AddressBookNotFoundException(string message) : base(message) { }
}
public class InvalidNameException : Exception
{
    public InvalidNameException(string message) : base(message) { }
}

