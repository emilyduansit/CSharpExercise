using System;

class Person
{
    protected int age;
    public void SetAge(int n)
    {
        age = n;
        Console.WriteLine("My age is {0} years old",age);
    }

    public void Greet()
    {
        Console.WriteLine("Hello Everyone");
    }


}
class Student : Person
{
    public void GoToClass()
    {
        Console.WriteLine("I will go to class");
    }

    public void ShowAge()
    {
        Console.WriteLine("I am {0} years old",age);
    }
}
class Teacher : Person
{
    private string subject;
    public void Explain()
    {
        Console.WriteLine("Explanation begins");
    }
}

namespace Class_Student_Teacher
{
    class Program
    {
        static void Main(string[] args)
        {
           Person person = new Person();
           Student student = new Student();
           Teacher teacher = new Teacher();

            person.Greet();
            student.SetAge(21);
            student.ShowAge();

            teacher.SetAge(30);
            teacher.Greet();
            teacher.Explain();

        }
    }
}
