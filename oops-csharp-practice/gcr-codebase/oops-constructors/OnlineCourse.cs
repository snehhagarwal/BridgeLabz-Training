using System;

class Course
{
    public string CourseName;
    public int Duration;
    public double Fee;
    public static string InstitueName="ABC Institude";

    public Course(string name,int time,double fee)
    {
        this.CourseName=name;
        this.Duration=time;
        this.Fee=fee;
    }
    public void DisplayCourse()
    {
        Console.WriteLine("Course name: " + CourseName);
        Console.WriteLine("Duration: " + Duration);
        Console.WriteLine("Fee: " + Fee);
        Console.WriteLine("Institude: " + InstitueName);
    }

    public static void UpdateInstitude(string name)
    {
        InstitueName=name;
    }
}

class OnlineCourse
{
    static void Main(string[] args)
    {
        Course c1=new Course("Java",30,5000);
        Course c2=new Course(".Net",40,9000);

        //displaying details
        c1.DisplayCourse();
        c2.DisplayCourse();

        Course.UpdateInstitude("PQR Institute");

        //after updation 
        c1.DisplayCourse();
        c2.DisplayCourse();
    }
}