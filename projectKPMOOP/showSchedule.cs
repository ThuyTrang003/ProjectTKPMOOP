
using projectKPMOOP.DAO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

public class ShowSchedule {
    ShowScheduleDAO showScheduleDAO = new ShowScheduleDAO();
    public ShowSchedule() {
    }

    private string ss_ID;

    private DateTime ss_StartTime;

    private DateTime ss_endTime;

    /// <summary>
    /// @param date
    /// </summary>
    public void displayScheduleByDate(DateTime date) {
        Console.Clear();
        //thực hiện dưới ShowScheduleDAO
        Console.WriteLine($"<<in ra lịch chiếu phim theo ngày {date.ToString("dd/MM/yyyy")}>>");
        getChoiceSchedule();
    }

    /// <summary>
    /// @param movie
    /// </summary>
    public void displayScheduleByMovie(String movie) {
        Console.Clear();
        //thực hiện dưới ShowScheduleDAO
        Console.WriteLine("<<in ra lịch chiếu phim theo phim>>");
        getChoiceSchedule();
    }

    public void getChoiceSchedule() {
        String choiceNumber="";
        Console.WriteLine("Nhập kí tự a,b,c tương ứng với các tùy chọn:");
        Console.WriteLine("a. Xem lịch chiếu theo tên phim");
        Console.WriteLine("b. Xem lịch chiếu theo ngày");
        Console.WriteLine("c. Thoát");
        Console.WriteLine("Hoặc nhập số thứ tự (1,2,3...) tương ứng với phim bạn muốn xem chi tiết và đặt vé");
        Console.Write("Vui lòng nhập: ");
        choiceNumber = Console.ReadLine();
        if (choiceNumber == "a") //xem lịch chiếu theo tên phim
        {
            Console.Clear();
            String movieName= getMovieName();
            displayScheduleByMovie(movieName);
        }
        else if (choiceNumber == "b")
        {
            Console.Clear();
            DateTime date = getDay();
            displayScheduleByDate((DateTime)date);
        }

    }

    public DateTime getDay() {
        Console.Clear();
        Console.Write("Nhập ngày muốn xem lịch chiếu(nhập đúng định dạng dd/MM/yyyy): ");
        String input = Console.ReadLine();
        String format = "dd/MM/yyyy";
        DateTime parsedDate;

        // Kiểm tra xem thông tin nhập vào có đúng cú pháp hay không
        bool isValid = DateTime.TryParseExact(input, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate);

        if (isValid)
        {
             return parsedDate;
        }
        else
        {
            return getDay();
        }
    }

    public String getMovieName() {
        Console.Clear();
        Console.Write("Nhập tên phim:");
        String movieName = Console.ReadLine();
        return movieName;
        }

    }