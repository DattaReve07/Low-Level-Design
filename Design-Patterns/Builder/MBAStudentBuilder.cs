namespace Builder;

public class MBAStudentBuilder : StudentBuilder
{
    public override StudentBuilder setSubjects()
    {
        List<string> mbaSubjects = new List<string>();
        mbaSubjects.Add("Marketing");
        mbaSubjects.Add("Finance");
        mbaSubjects.Add("Human Resource Management");
        this.Subjects = mbaSubjects;
        return this;
    }

}