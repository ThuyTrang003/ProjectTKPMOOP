
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{

    public Program()
    {
    }

    public static void displayMenu()
    {
        Console.WriteLine("ỨNG DỤNG QUẢN LÝ RẠP CHIẾU PHIM");
        Console.WriteLine("-----");
        Console.WriteLine("1. Xem lịch chiếu");
        Console.WriteLine("2. Xem lịch sử đặt vé");
        Console.WriteLine("3. Xem danh sách phim");
        getChoiceMenu();
    }

    public static void getChoiceMenu()
    {
        Console.Write("Yêu cầu nhập kí tự tương ứng để chọn chức năng:");
        String choiceNumber= Console.ReadLine();
        if (choiceNumber == "1")
        {
            DateTime now = DateTime.Now;
            ShowSchedule showSchedule = new ShowSchedule();
            Console.Clear();
            showSchedule.displayScheduleByDate(now);
        }
        else if (choiceNumber == "3")
        {
            Movie movie = new Movie();
            movie.displayListMovie();
            movie.getChoiceExit();
        }
        else 
        { 
            getChoiceMenu();
        }
    }

    static void Main(String[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        displayMenu();
    }
}