using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectKPMOOP.DAO
{
    internal class ShowScheduleDAO
    {
        DBConnection db = null;
        SqlCommand comm;

        public ShowScheduleDAO()
        {
            db = new DBConnection();
        }
        public void getMovie(DateTime date)
        {

        }
        public void getSchedule(String movie)
        {

        }
    }
}
