using System.Text.RegularExpressions;

namespace ConsoleStudent.ManageLogics;

public static class Modify
{
    public static void ModifyStudent(List<Student> students)
    {
        if (students.Count <= 0)
        {
            Console.WriteLine("수정이 가능한 학생이 없습니다.");
        }
        else
        {
            Console.WriteLine("수정하고 싶은 학생의 Id를 입력해주세요");
            int id = Convert.ToInt32(Console.ReadLine());

            var temp = students.FirstOrDefault(x => x.Id == id);
            Console.WriteLine(temp);
            if (temp == null)
            {
                Console.WriteLine("id 정보가 존재하지 않습니다.");
            }
            else
            {
                Console.WriteLine("수정할 사항을 입력해주세요. (수정은 학년과 졸업 여부만 가능합니다.)");
                Console.WriteLine("수정이 필요없는 경우 엔터를 눌려주세요");
        
                Console.Write("학년: ");
                string? inputGrade= Console.ReadLine();
                int modifiedGrade = 0;
                if (inputGrade != "")
                {
                    while (!int.TryParse(inputGrade, out modifiedGrade))
                    {
                        Console.WriteLine("유효한 학년을 정수로 입력해주세요.");
                        inputGrade = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("값이 입력되지 않아 수정이 이뤄지지 않습니다.");
                    modifiedGrade = temp.Grade;
                }

                Console.Write("\n졸업 여부: ");
                string? inputState = Console.ReadLine();
                bool modifiedState = false;
                while (!Regex.IsMatch(inputState, "^[ox]$"))
                {
                    Console.WriteLine("영소문자로 o,x 만을 입력해주세요.");
                    inputState = Console.ReadLine();
                }

                if (inputState == "o")
                {
                    modifiedState = true;
                }
                else if (inputState == "x")
                {
                    modifiedState = false;
                }

                temp.ModifyStudent(modifiedGrade, modifiedState);
                Console.WriteLine("수정이 완료되었습니다. 변경된 내용은 아래와 같습니다.");
                temp = students.FirstOrDefault(x => x.Id == id);
                Console.WriteLine(temp.GetInfoOfStudent());
            }
        }
    }
}