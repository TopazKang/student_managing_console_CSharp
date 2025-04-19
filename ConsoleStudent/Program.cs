// 학생부 콘솔 프로그램 제작 연습

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using ConsoleStudent;
using ConsoleStudent.ManageLogics;
using ConsoleStudent.Managers;

class Program
{
    static void Main(String[] args)
    {
        var manager = new StudentManager();
        manager.Run();
    }
}