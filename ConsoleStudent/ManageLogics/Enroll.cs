namespace ConsoleStudent.ManageLogics;

public static class Enroll
{
    public static void RegisterStudent(List<Student> students)
    {
        Console.WriteLine("학생 명부 등록을 위해 정보를 입력해주세요.");

        int id = 1;
        if (students.Count > 0)
        {
            id = students.Max(x => x.Id) + 1;
        }

        Console.Write("이름: ");
        string? name = Console.ReadLine();
        
        Console.Write("\n부서: ");
        string? department = Console.ReadLine();
        
        Console.Write("\n학년: ");
        string? grade = Console.ReadLine();
        int _tempGrade = 0;
        while (!int.TryParse(grade, out _tempGrade))
        {
            Console.WriteLine("학년에 유효한 값을 입력해주세요.");
            grade = Console.ReadLine();
        }
        
        Console.Write("\n생년월일: ");
        string? birth = Console.ReadLine();
        
        var student = new Student(id, name, department, _tempGrade, birth, false);
        
        students.Add(student);
        Console.WriteLine("학생 등록이 완료되었습니다.");
        
        id = students.Max(x => x.Id);
        var temp = students.FirstOrDefault(x => x.Id == id);
        
        
        if (temp != null)
        {
            Console.WriteLine("\n<등록한 학생>");
            var enrolledStudent = temp.GetInfoOfStudent();
            Console.WriteLine($"{enrolledStudent}");
        }
    }
}