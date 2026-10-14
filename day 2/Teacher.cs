public class Teacher
{
     string Fulname;
     string subject ;
     int experience;
    public Teacher(){}
    public Teacher(string name, string sub)
    {
        Fulname=name;
        subject=sub;
    }
    public Teacher(string name, string sub, int ex)
    {
        Fulname=name;
        subject=sub;
        experience=ex;
    }
    public string Teach()
    {
        return $"{Fulname} is teaching {subject}";
    }
    public void SetExperience(int year)
    {
        experience=year;
    }
    public int GetExperience()
    {
        return experience;
    }
}
    