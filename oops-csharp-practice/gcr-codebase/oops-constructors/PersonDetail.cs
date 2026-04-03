using System;

class Person
{
    public string Name;
    public int Age;

    //parameterized constructor 
    public Person(string name,string age)
    {
        this.Name=name;
        this.Age=age;

    }

    //passing object in constructor
    public Person(Person p)
    {
        Name=p.Name;
        Age=p.Age;
    }

    //display function 
    public void Display()
    {
        Console.WriteLine("Name: " + Name + " Age:" + Age);
    }
}

class PersonDetail
{
    static void Main(string[] args)
    {
        //take input from user
        Console.Write("Enter Name: ");
        string name=Console.ReadLine();

        Console.Write("Enter age: ");
        int age=Convert.ToInt32(Console.ReadLine());

        //object creation 
        Person p1=new Person(name,age);
        Person p2=new Person(p1);

        p1.Display();
    }
}