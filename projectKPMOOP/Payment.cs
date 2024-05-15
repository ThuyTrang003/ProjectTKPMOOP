
using projectKPMOOP.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Payment {

    PaymentDAO paymentDAO = new PaymentDAO();
    public Payment() {
        //lấy p_ID từ DAO
        string p_ID = "";
        this.p_ID = p_ID;
    }

    private String p_ID;

    private int p_totalPay;

    private int p_drinks;

    private int p_seatQuantity;

    /// <summary>
    /// @param scheduleID
    /// </summary>
    /// 
    public int getP_seatquantity()
    {
        return this.p_seatQuantity;
    }

    public String getP_ID()
    {
        return (this.p_ID);
    }
    public void getTicketQuantity(String scheduleID) {
        // TODO implement here
        Console.WriteLine("Nhập số lượng vé:");
        String seats= Console.ReadLine();
        int seatQuantity;
        bool isValid = int.TryParse(seats, out seatQuantity);

        if (isValid)
        {
            if (seatQuantity > 0)
            {
                if (paymentDAO.checkSeatAvailable(scheduleID,seatQuantity))
                {
                    p_seatQuantity = seatQuantity;

                }
                else
                {
                    Console.WriteLine("Số lượng vé còn lại không đủ");
                    getTicketQuantity(scheduleID);

                }
            }
        }
        else
        {
            Console.WriteLine("Kí tự không hợp lệ");
            getTicketQuantity(scheduleID);
        }
    }

    public void getDrinkQuantity() {
        Console.WriteLine("Nhập số lượng nước uống:");
        String drinks = Console.ReadLine();
        int drinkQuantity;
        bool isValid = int.TryParse(drinks, out drinkQuantity);
        if (isValid)
        {
            if (drinkQuantity >= 0)
            {
                p_drinks = drinkQuantity;
            }    
        }
        else
        {
            getDrinkQuantity();
        }
    }

    public bool confirmBooking() {
        // TODO implement here
        Console.WriteLine("Chọn 1 để xác nhận đặt vé, 2 để hủy");
        String isConfirm=Console.ReadLine();
        if (isConfirm == "1")
            return true;
        else if (isConfirm == "2")
            return false;
        else 
            return confirmBooking();
    }

    /// <summary>
    /// @param paymentID
    /// </summary>
    public void displayBookingInfor(String paymentID) {
        paymentDAO.displayBookingInfor(paymentID);
    }

    public void getChoiceExit(String movie_ID) {
        // TODO implement here
        Console.WriteLine("Nhập 0 để kết thúc đặt vé");
        String choiceNumber=Console.ReadLine();
        if (choiceNumber == "0")
        {
            Movie movie = new Movie();
            movie.displayMovieDetail(movie_ID);
        }
        else getChoiceExit(movie_ID);         
    }
}