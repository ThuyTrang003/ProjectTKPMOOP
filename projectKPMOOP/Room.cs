
using projectKPMOOP.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Room {
    RoomDAO roomDAO=new RoomDAO();
    public Room() {
    }

    private String room_ID;

    private int r_capacity;

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
        // TODO implement here
    }

}