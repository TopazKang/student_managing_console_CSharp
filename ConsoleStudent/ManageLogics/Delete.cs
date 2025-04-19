namespace ConsoleStudent.ManageLogics;

public static class Delete
{
    public static void DeleteStudent(List<Student> students)
    {
        Console.WriteLine("정보를 삭제할 학생의 id를 입력해주세요.");
        int id = Convert.ToInt32(Console.ReadLine());
        
        var temp = students.FirstOrDefault(x => x.Id == id);

        if (temp == null)
        {
            Console.WriteLine("id에 해당하는 정보가 존재하지 않습니다.");
        }
        else
        {
            Console.WriteLine($"id: {id}에 해당하는 학생 {temp.Name}의 정보를 삭제합니다.");
            students.Remove(temp);
            
            temp = students.FirstOrDefault(x => x.Id == id);
            if (temp == null)
            {
                Console.WriteLine("삭제가 성공적으로 진행되었습니다.");
            }
            else
            {
                Console.WriteLine("삭제에 실패하였습니다. 재시도 바랍니다.");
            }
        }
    }
}