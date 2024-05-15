
using projectKPMOOP.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Room {
    RoomDAO roomDAO=new RoomDAO();
    
    private String room_ID;

    private int r_capacity;
    public Room()
    {
    }
    public Room(String room_ID) 
    { 
        this.room_ID = room_ID; 
    }
    /// <summary>
    /// @param schedueID
    /// </summary>
    public void displaySeatChart(String scheduleID) {
        // TODO implement here
        
        roomDAO.getSeatChart(scheduleID);
    }

    /// <summary>
    /// @param seatQuantity 
    /// @param scheduleID
    /// </summary>
    public void getSeats(int seatQuantity, String scheduleID) {
        Console.WriteLine("Vui lòng nhập vị trí chỗ ngồi:");
        List<Seat> seats= new List<Seat>();
        for (int i=0; i<seatQuantity; i++)
        {
            Console.Write($"Nhập chỗ ngồi {i+1}:");
            String seat_ID= Console.ReadLine();
            bool isBool= roomDAO.checkSeat(seat_ID, scheduleID);
            if (isBool)
            {
                seats.Add(new Seat(seat_ID));
            }
            else
            {
                Console.WriteLine("Không hợp lệ, vui lòng nhập lại");
                Console.WriteLine("-----");
                getSeats(seatQuantity, scheduleID);
            }
        }
        //thêm các chỗ ngồi được đặt vào database
    }

}