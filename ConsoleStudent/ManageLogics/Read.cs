using System.Text.RegularExpressions;

namespace ConsoleStudent.ManageLogics;

public static class Read
{
    public static void ReadInfo(List<Student> students)
    {
        Console.WriteLine("조회 방식을 선택해주세요.");
        Console.WriteLine("\t1. 선택 조회");
        Console.WriteLine("\t2. 전체 조회");
        Console.WriteLine("\t0. 이전 메뉴");
        Console.WriteLine("--------------------------");
        
        string? inputRead = Console.ReadLine();
        int selected = 0;
        while (!Regex.IsMatch(inputRead, "^[0-2]$") || !int.TryParse(inputRead, out selected))
        {
            Console.WriteLine("선택지에 유효한 값을 입력해주세요.");
            inputRead = Console.ReadLine();
        }

        switch (selected)
        {
            case 1:
                Console.WriteLine("선택 조회를 진행합니다.");
                Console.WriteLine("조회할 학생의 id를 입력해주세요.");
                int id = int.Parse(Console.ReadLine());
                var temp = students.FirstOrDefault(x => x.Id == id);
                if (temp == null)
                {
                    Console.WriteLine("id에 해당하는 정보가 존재하지 않습니다.");
                }
                else
                {
                    var tmp = temp.GetInfoOfStudent();
                    Console.WriteLine(tmp);
                }
                break;
            case 2:
                Console.WriteLine("전체 조회를 진행합니다.");
                foreach (var student in students)
                {
                    string tmp = student.GetInfoOfStudent();
                    Console.WriteLine(tmp);
                }
                break;
            case 0:
                Console.WriteLine("이전 메뉴로 돌아갑니다.");
                break;
        }
    }
}