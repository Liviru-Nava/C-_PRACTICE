using System;

//create a student class
class  Student
{
    //declare the attributes for student class
    private string name { get; set; }
    private int age { get; set; }

    //create a parameterized constructor
    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    //create a method to display the student details
    public void displayStudentDetails()
    {
        Console.WriteLine($"Student Details\n - Student Name: {name} \n - Student Age: {age}");
    }
}

//create a main class
class Program
{
    public static void Main(String[] args)
    {
        //create a object for student class
        Student student1 = new Student("Liviru Navaratna", 20);

        //display the details of the new Student
        student1.displayStudentDetails();
    }
}