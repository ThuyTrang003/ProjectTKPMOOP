
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
    }

    public static int getChoiceMenu()
    {
        Console.Write("Yêu cầu nhập kí tự tương ứng để chọn chức năng:");
        String choiceNumber= Console.ReadLine();
        if (choiceNumber == "1")
        {
            return 1;
        }
        else if (choiceNumber == "3")
        {
            return 3;
        }
        else { return getChoiceMenu();}
    }
    static void Main(String[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        displayMenu();
        int choiceMenu = getChoiceMenu();
        if (choiceMenu == 1)
        {
            DateTime now = DateTime.Now;
            ShowSchedule showSchedule= new ShowSchedule();
            showSchedule.displayScheduleByDate(now);
            String choiceNumberSchedule= showSchedule.getChoiceSchedule();
            if (choiceNumberSchedule == "a") //xem lịch chiếu theo tên phim
            {
                Console.WriteLine("Nhập tên phim:");
                String movieName= Console.ReadLine();
            }
        }
        else if (choiceMenu == 3) 
        {
            Movie movie = new Movie();
            movie.displayListMovie();
            movie.getChoiceExit();
        }
    }
}