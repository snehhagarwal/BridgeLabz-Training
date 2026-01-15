public class AddressBookModel
{
    //private fields 
    private string address;
    private string firstName;
    private string lastName;
    private string city;
    private string state;
    private string zip;
    private int phoneNumber;
    private string email;

    //public properties
    public string FirstName { get { return firstName; } set { firstName = value; } }
    public string LastName { get { return lastName; } set { lastName = value; } }
    public string Address { get { return address; } set { address = value; } }
    public string City { get { return city; } set { city = value; } }
    public string State { get { return state; } set { state = value; } }
    public string Zip { get { return zip; } set { zip = value; } }
    public int PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
    public string Email { get { return email; } set { email = value; } }
}
