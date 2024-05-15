
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Movie {

    public Movie() {
    }

    private String movie_ID;

    private String title;

    private String genre;

    private int lenght;

    private String country;

    private String director;

    private DateTime releaseTime;

    private String actor;

    private String plot;
    public Movie(String movie)
    {
        this.movie_ID = movie;
    }
    public void displayMovieDetail(String movie)
    {
        Console.Clear();
        //lấy thông tin phim dưới DAO
        Console.WriteLine("<<Thông tin phim>>");
        getChoiceMovieDetail(movie);
    }
    public void getChoiceMovieDetail(String movie)
    {
        Console.WriteLine("Nhập kí tự tương ứng để chọn:");
        Console.WriteLine("a. Chỉnh sửa phim");
        Console.WriteLine("b. Xóa phim");
        Console.WriteLine("c. Thoát");
        Console.WriteLine("Hoặc chọn suất chiếu tương ứng để đặt vé");
        String choiceNumber = Console.ReadLine();
        if (choiceNumber == "a")
        {
            getChoiceEditMovie(movie);  
        }
        else if (choiceNumber == "b")
        {
            getDeleteMovie(movie);
        }
        else if (choiceNumber == "1") //ví dụ đặt vé cho suất đầu tiên
        {
            //ss_ID của suất chiếu được chọn 
            String scheduleID = "";
            Room room = new Room();
            Payment payment = new Payment(); //bắt buộc phải new 1 payment
            payment.getTicketQuantity(scheduleID);
            room.displaySeatChart(scheduleID);
            room.getSeats(payment.getP_seatquantity(), scheduleID);
            payment.getDrinkQuantity();
            bool isConfirm = payment.confirmBooking();
            if (isConfirm)
            {
                Console.Clear();
                Console.WriteLine("Đặt vé thành công;");
                payment.displayBookingInfor(payment.getP_ID());
                payment.getChoiceExit(movie);
            }
            else
            {
                displayMovieDetail(movie);
            }
        }
        else if (choiceNumber== "c")
        {
            Console.Clear();
            Program.displayMenu();
        }    
        else
        {
            Console.Clear();
            displayMovieDetail(movie);
        }

    }
    public void getChoiceEditMovie(String movie)
    {
        Console.Clear();
        Console.WriteLine("Bạn muốn sửa thông tin phim: ");
        Console.WriteLine("0. Thoát");
        Console.WriteLine("1. Thể loại");
        Console.WriteLine("2. Thời lượng");
        Console.WriteLine("3. Quốc gia");
        Console.WriteLine("4. Mô tả");
        Console.WriteLine("5. Lịch chiếu");
        Console.WriteLine("6. Tiêu đề");
        Console.WriteLine("7. Lưu chỉnh sửa");
        Console.WriteLine("Nhập số thứ tự tương ứng");
        String choiceNumber = Console.ReadLine();
        if (choiceNumber == "0")
        {
            getChoiceMovieDetail(movie);
        }
        else if (choiceNumber == "1")
        {
            enterGenre();
        }
        else if (choiceNumber == "2")
        {
            enterLength();
        }
        else if (choiceNumber == "3")
        {
            enterCountry();
        }
        else if (choiceNumber == "4")
        {
            enterPlot();
        }
        else if (choiceNumber == "5")
        {
            enterReleaseTime();
        }
        else if (choiceNumber == "6")
        {
            enterTitle();
        }
        else if (choiceNumber == "7")
        {
            confirmSave();
        }
    }
    public void enterGenre()
    {
        Console.Clear();
        Console.Write("Thể loại: ");
        string input = Console.ReadLine();
        getChoiceMovieDetail(movie_ID);
    }
    public void enterLength()
    {
        Console.Clear();
        Console.Write("Thời lượng: ");
        string input = Console.ReadLine();
        getChoiceMovieDetail(movie_ID);
    }
    public void enterCountry()
    {
        Console.Clear();
        Console.Write("Quốc gia: ");
        string input = Console.ReadLine();
        getChoiceMovieDetail(movie_ID);
    }
    public void enterReleaseTime()
    {
        Console.Clear();
        Console.Write("Lịch chiếu: ");
        string input = Console.ReadLine();
        getChoiceMovieDetail(movie_ID);
    }
    public void enterPlot()
    {
        Console.Clear();
        Console.Write("mô tả: ");
        string input = Console.ReadLine();
        getChoiceMovieDetail(movie_ID);
    }
    public void enterTitle()
    {
        Console.Clear();
        Console.Write("Tiêu đề: ");
        string input = Console.ReadLine();
        getChoiceMovieDetail(movie_ID);
    }
    public void confirmSave()
    {
        Console.Clear();
        Console.WriteLine("Chỉnh sửa phim thành công");
        Console.Write("Ấn phím 0 để trở về thông tin phim: ");
        String choiceNumber = Console.ReadLine();
        if (choiceNumber == "0")
        {
            Console.Clear();
            getChoiceMovieDetail(movie_ID);
        }
    }
    public void getDeleteMovie(String movie)
    {
        Console.WriteLine("Bạn có chắc chắn muốn xóa phim");
        Console.WriteLine("0. Thoát");
        Console.WriteLine("1. Xác nhận xóa phim");
        Console.Write("Vui lòng nhập: ");
        String choice = Console.ReadLine();
        if (choice == "0")
        {
            getChoiceMovieDetail(movie);
        }
        if (choice == "1")
        {
            Console.Clear();
            Console.WriteLine("Xóa phim thành công");
            Console.Write("Ấn phím 0 để trở về danh sách phim: ");
            String c = Console.ReadLine();
            if (c == "0")
            {
                Console.Clear();
                getChoiceListMovie();
            }
        }
    }
    public void displayListMovie() {
        //lấy dưới DAO
        getChoiceListMovie();
    }
    public void getChoiceListMovie()
    {
        Console.Clear();
        Console.WriteLine("<<Danh sách phim>>");
        Console.WriteLine("\n");
        Console.WriteLine("Nhập số thứ tự tương ứng với từng phim để xem thông tin phim");
        Console.WriteLine("0. Thoát");
        Console.WriteLine("1. Thêm phim");
        Console.Write("Vui lòng nhập: ");
        String choiceNumber = Console.ReadLine();
        if (choiceNumber == "0")
        {
            Console.Clear();
            Program.displayMenu();
        }
        if (choiceNumber == "1")
        {
            addIDMovie();
        }
        if (choiceNumber == "6") //ví dụ chọn 6 để xem thông tin phim "Mắt Biết" 
        {
            String movie_ID = "";
            //lấy movie_ID dựa vào phim được chọn dưới DAO
            displayMovieDetail(movie_ID);
        }
    }
    public void addIDMovie()
    {
        Console.Clear();
        Console.Write("ID phim: ");
        string input = Console.ReadLine();
        addNameMovie();
    }
    public void addNameMovie()
    {
        Console.Clear();
        Console.Write("Tên phim: ");
        string input = Console.ReadLine();
        addYearMovie();
    }
    public void addYearMovie()
    {
        Console.Clear();
        Console.Write("Năm phát hành: ");
        string input = Console.ReadLine();
        addGenreMovie();
    }
    public void addGenreMovie()
    {
        Console.Clear();
        Console.Write("Thể loại: ");
        string input = Console.ReadLine();
        addActorMovie();
    }
    public void addActorMovie()
    {
        Console.Clear();
        Console.Write("Diễn Viên: ");
        string input = Console.ReadLine();
        addDirectorMovie();
    }
    public void addDirectorMovie()
    {
        Console.Clear();
        Console.Write("Đạo diễn: ");
        string input = Console.ReadLine();
        addPlotMovie();
    }
    public void addPlotMovie()
    {
        Console.Clear();
        Console.Write("Mô tả: ");
        string input = Console.ReadLine();
        addSuccess();
    }
    public void addSuccess()
    {
        Console.Clear();
        Console.WriteLine("Thêm phim thành công");
        Console.WriteLine("Ấn phím 0 để trở về danh sách phim");
        String choiceNumber = Console.ReadLine();
        if (choiceNumber == "0")
        {
            Console.Clear();
            getChoiceListMovie();
        }
    }
}
