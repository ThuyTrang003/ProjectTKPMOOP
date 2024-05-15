
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Payment {

    public Payment() {
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
        Console.WriteLine("Nh?p s? l??ng vé:");
        String seats= Console.ReadLine();
        //ki?m tra s? l??ng vé có ít h?n s? ghé tr?ng không
        int seatQuantity;
        bool isValid = int.TryParse(seats, out seatQuantity);

        if (isValid)
        {
            if (seatQuantity >= 0)
            {
                p_seatQuantity = seatQuantity;
            }
        }
        else
        {
            getTicketQuantity(scheduleID);
        }
    }

    public void getDrinkQuantity() {
        Console.WriteLine("Nh?p s? l??ng n??c u?ng(n?u ):");
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
        Console.WriteLine("Ch?n 1 ?? xác nh?n ??t vé, 2 ?? h?y");
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
        // TODO implement here
    }

    public void getChoiceExit() {
        // TODO implement here
        Console.WriteLine("Nh?p 0 ?? ?? k?t thúc ??t vé");
        String choiceNumber=Console.ReadLine();
        if (choiceNumber == "0")
        {
            Movie movie = new Movie();
            movie.displayMovieDetail();
        }
        else getChoiceExit();         
    }
}