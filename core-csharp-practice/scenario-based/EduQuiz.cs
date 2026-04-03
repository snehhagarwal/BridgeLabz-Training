using System;

class EduQuiz
{
    //array for questions
    static string[] question=new string[10];
    //array for correct answers
    static string[] correctAnswer=new string[10];
    //to check whether the answers are set or not
    static bool setAnswer=false;
    //role based 
    static bool isTeacher=false; 
    static void Main(string[] args)
    {
        int choice;

        //menu for role
        do
        {
            Console.WriteLine("\nEduQuiz Menu");
            Console.WriteLine("1. Teacher");
            Console.WriteLine("2. Student");
            Console.WriteLine("3. Exit");
            Console.Write("Select choice: ");
            choice=Convert.ToInt32(Console.ReadLine());

            //switch case for roles
            switch (choice)
            {
                case 1:
                    isTeacher=true;
                    Teacher();
                    break;
                case 2:
                    isTeacher=false;
                    Student();
                    break;
                case 3:
                    Console.WriteLine("Exiting the program");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            
        }while(choice!=3);

    }

    //for teacher 
    static void Teacher()
    {
        if (!isTeacher)
        {
            Console.WriteLine("Access Denied");
            return;
        }
        //entering the questions and answers
        Console.WriteLine("Enter questions and their answers: ");
        for(int i = 0; i < 10; i++)
        {
            Console.Write("\nEnter Question " + (i+1) + ": ");
            question[i]=Console.ReadLine() ?? "";

            Console.Write("Correct Answer of Q" + (i+1) + ": ");
            correctAnswer[i]=Console.ReadLine() ?? "";
        }

        setAnswer=true;
        Console.WriteLine("\nQuestions and answers saved successfully");
    }

    //for student
    static void Student()
    {
        if (isTeacher)
        {
            Console.WriteLine("Teachers cannot give quiz");
            return;
        }

        if (!setAnswer)
        {
            Console.WriteLine("\nThe answers are not yet set");
            return;
        }

        //student giving the quiz
        Console.WriteLine("\nStudent Quiz");
        string[] studentAnswer=new string[10];

        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("\nQ"+(i+1) +": " + question[i]);
            Console.Write("Your Answer: ");
            studentAnswer[i]=Console.ReadLine() ?? "";
        }

        int score=Calculate(correctAnswer,studentAnswer);
        double percentage=(score/10.0)*100;

        //printing all the three results
        Console.WriteLine("\nResult");
        Console.WriteLine("Scores: " + score + "/10");
        Console.WriteLine("Percentage: " + percentage + "%");

        Console.WriteLine(percentage>=50 ? "Status: PASS" : "Status: FAIL");
    }

    //score calculation 
    static int Calculate(string[] correct,string[] student)
    {
        int score=0;

        Console.WriteLine("\n FEEDBACK");
        for(int i = 0; i < correct.Length; i++)
        {
            Console.WriteLine("\nQ"+(i+1) + ": " + question[i]);

            //case insensitive case handeled
            if (correct[i].Equals(student[i], StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Result : Correct");
                score++;
            }
            else
            {
                Console.WriteLine("Result : Incorrect");
            }
        }
        return score;
    }
}