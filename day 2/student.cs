public class Student
{
    string? fulname;
    int age;
    int grade;
    public Student(){}
    public Student(string name, int age)
    {
        fulname=name;
        this.age=age;
    }
    public Student(string name, int age, int grad)
    {
        fulname=name;
        this.age=age;
        grade=grad;
    }
    public void Study()
    {
        System.Console.WriteLine($"{fulname} is studying");
    }
    public void SetGrade(int grade)
    {
        this.grade=grade;
    }
    public int Getgrade()
    {
        return grade;
    }
}