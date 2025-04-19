namespace ConsoleStudent;

public class Student
{
    public int Id { get; init; }

    public string Name { get; init; } = string.Empty;

    public string Department { get; init; } = string.Empty;
    
    public int Grade { get; private set; }
    
    public string Birth { get; init; } = string.Empty;
    
    public bool Graduated { get; private set; }

    public Student(int id, string name, string department, int grade, string birth, bool graduated)
    {
        Id=id;
        Name=name;
        Department=department;
        Grade=grade;
        Birth=birth;
        Graduated=graduated;
    }

    public string GetInfoOfStudent()
    {
        return $" {Id} - name: {Name}, department: {Department}, grade: {Grade}, birth: {Birth}, state: {Graduated}";
    }

    public void ModifyStudent(int grade, bool graduated)
    {
        this.Grade = grade;
        this.Graduated = graduated;
    }
}