// 학생부 콘솔 프로그램 제작 연습

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using ConsoleStudent;
using ConsoleStudent.ManageLogics;

class Program
{
    static List<Student> students = new();

    static void Main(String[] args)
    {
        bool manageState = true;
        while (manageState)
        {
            Console.WriteLine("학생부 관리 프로그램입니다. 선택지를 골라서 학생 명부를 관리할 수 있습니다.");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("\t1. 등록");
            Console.WriteLine("\t2. 조회");
            Console.WriteLine("\t3. 수정");
            Console.WriteLine("\t4. 삭제");
            Console.WriteLine("\t0. 종료");
            Console.WriteLine("-----------------------------------------------");
            
            string? initialSelection = Console.ReadLine();
            int _selection = 0;
            while (!Regex.IsMatch(initialSelection, "^[0-4]$") || !int.TryParse(initialSelection, out _selection))
            {
                Console.WriteLine("선택지 범위에 있는 유효한 숫자를 입력해주세요.");
                initialSelection = Console.ReadLine();
            }

            switch (_selection)
            {
                case 1:
                    Enroll.RegisterStudent(students);
                    Console.WriteLine("------------------ 로직 종료 ------------------");
                    break;
                case 2:
                    Read.ReadInfo(students);
                    Console.WriteLine("------------------ 로직 종료 ------------------");
                    break;
                case 3:
                    Modify.ModifyStudent(students);
                    Console.WriteLine("------------------ 로직 종료 ------------------");
                    break;
                case 4:
                    Delete.DeleteStudent(students);
                    Console.WriteLine("------------------ 로직 종료 ------------------");
                    break;
                case 0:
                    Console.WriteLine("프로그램을 종료합니다.");
                    manageState = false;
                    break;
            }
        }
    }
}