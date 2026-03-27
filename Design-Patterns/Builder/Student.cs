namespace Builder;

public class Student(StudentBuilder builder)
{
    private int RollNo { get; } = builder.RollNo;
    private string Name { get; } = builder.Name;
    private int? Age { get; } = builder.Age;
    private string? Gender { get; } = builder.Gender;
    private string? Email { get; } = builder.Email;
    private string? Phone { get; } = builder.Phone;
    private List<String> Subjects { get; } = builder.Subjects;
    private string? FatherName { get; } = builder.FatherName;
    private string? MotherName { get; } = builder.MotherName;

    public override string ToString()
    {
        return
            $"Student [RollNo={RollNo}, Name={Name}, Age={Age}, Gender={Gender}, Email={Email}, Phone={Phone}, Subjects={string.Join(", ", Subjects)}, FatherName={FatherName}, MotherName={MotherName}]";
    }
}