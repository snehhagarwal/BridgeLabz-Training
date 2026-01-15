// Model class demonstrating encapsulation
public class AddressBookModel{
   private string address;
   private string firstName;
   private string LastName;
   private string city;
   private string state;
   private string Zip;
   private int phoneNumber;
   private string email;

   public string FirstName{get {return firstName;} set{firstName=value;}}
   public string LastName{get{return LastName;} set{ lastName=value;}}
   public string Address{get{return address;} set{address=value;}}
   public string City{get{ return city;} set{city=value;}}
   public string State{get{return state;} set{state=value;}}
   public string Zip{get{return zip;} set{Zip=value;}}
   public int PhoneNumber{get{return phoneNumber;} set{phoneNumber=value;}}
   public string Email{get{return email;} set{email=value;}}

}
