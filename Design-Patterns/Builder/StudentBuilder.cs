namespace Builder;

public abstract class StudentBuilder
{
    public int RollNo { get; set; }
    public string Name { get; set; }
    public int? Age { get; set; }
    public string? Gender { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public List<String> Subjects { get; set; }
    public string? FatherName { get; set; }
    public string? MotherName { get; set; }

    public StudentBuilder setRollNo(int rollNo)
    {
        this.RollNo = rollNo;
        return this;
    }

    public StudentBuilder setName(string name)
    {
        this.Name = name;
        return this;
    }

    public StudentBuilder setAge(int age)
    {
        this.Age = age;
        return this;
    }

    public StudentBuilder setGender(string gender)
    {
        this.Gender = gender;
        return this;
    }

    public StudentBuilder setEmail(string email)
    {
        this.Email = email;
        return this;
    }

    public StudentBuilder setPhone(string phone)
    {
        this.Phone = phone;
        return this;
    }

    public StudentBuilder setMotherName(string motherName)
    {
        this.MotherName = motherName;
        return this;
    }

    public StudentBuilder setFatherName(string fatherName)
    {
        this.FatherName = fatherName;
        return this;
    }

    public abstract StudentBuilder setSubjects();

    public Student build()
    {
        return new Student(this);
    }
}