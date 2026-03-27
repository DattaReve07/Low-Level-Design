namespace Builder;

public class BCAStudentBuilder : StudentBuilder
{
    public override StudentBuilder setSubjects()
    {
        List<string> bcaSubjects = new List<string>();
        bcaSubjects.Add("Finance");
        bcaSubjects.Add("Computer Science");
        bcaSubjects.Add("Health Industries");
        bcaSubjects.Add("Java");
        Subjects = bcaSubjects;
        return this;
    }
}