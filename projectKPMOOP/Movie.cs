
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
        Console.Write("Vui lòng nhập: ");
        String choiceNumber= Console.ReadLine();
        if (choiceNumber == "0" ) 
        {
            Program.displayMenu();
        }
        //nhập để xem thông tin phim
    }
    public void displayMovieDetail() {
        // TODO implement here
    }

    public void getChoiceEditMovie() {
        // TODO implement here
    }

    public void enterGenre() {
        // TODO implement here
    }

    public void confirmSave() {
        // TODO implement here
    }

    

    public void getChoiceMovieDetail() {
        // TODO implement here
    }

}