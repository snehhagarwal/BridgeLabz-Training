using System;

class Program
{
    static void Main(string[] args)
    {
        Teacher t=new Teacher();
        t.Name="Ram";
        t.Age=25;
        t.Subject="Maths";
        t.Display();

        Console.WriteLine();

        Student s=new Student();
        s.Name="Ravi";
        s.Age=20;
        s.Grade="B.Tech";
        s.Display();

        Console.WriteLine();

        Staff st=new Staff();
        st.Name="Shivani";
        st.Age=30;
        st.Department="Finance";
        st.Display();
    }
}