
using projectKPMOOP.DAO;
using System;
using System.Collections.Generic;
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
        showScheduleDAO.getMovie(date);
    }

    /// <summary>
    /// @param movie
    /// </summary>
    public void displayScheduleByMovie(String movie) {
        showScheduleDAO.getSchedule(movie);
    }

    public String getChoiceSchedule() {
        String choiceNumber="";
        Console.WriteLine("Nhập kí tự a,b,c tương ứng với các tùy chọn:");
        Console.WriteLine("a. Xem lịch chiếu theo tên phim");
        Console.WriteLine("b. Xem lịch chiếu theo ngày");
        Console.WriteLine("c. Thoát");
        Console.WriteLine("Hoặc nhập số thứ tự (1,2,3...) tương ứng với phim bạn muốn xem chi tiết và đặt vé");
        Console.WriteLine("Vui lòng nhập: ");
        choiceNumber = Console.ReadLine();
        return choiceNumber;
    }

    public void getDay() {
        // TODO implement here
    }

    public void getMovieName() {
        // TODO implement here
    }

}