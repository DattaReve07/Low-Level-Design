namespace Builder;

public class StudentRegistrationDirector
{
    private StudentBuilder studentBuilder;

    public StudentRegistrationDirector(StudentBuilder studentBuilder)
    {
        this.studentBuilder = studentBuilder;
    }

    public Student? createStudent() {
        if(studentBuilder is MBAStudentBuilder)
        {
            return createMBAStudent();
        }

        if(studentBuilder is BCAStudentBuilder)
        {
            return createBCAStudent();
        }
        return null;
    }


    public Student createMBAStudent()
    {
        studentBuilder.setRollNo(1).setName("John Doe").setAge(25).setGender("Male").setEmail("nothingbro").setFatherName("John Doe Sr.").setMotherName("Jane Doe").setPhone("1234567890");
        studentBuilder.setSubjects();
        return new Student(this.studentBuilder);
    }

    public Student createBCAStudent()
    {
        studentBuilder.setRollNo(2).setName("John Bache").setAge(25).setGender("Male").setEmail("nothingbro").setPhone("1234567890");
        studentBuilder.setSubjects();
        return new Student(studentBuilder);
    }

}