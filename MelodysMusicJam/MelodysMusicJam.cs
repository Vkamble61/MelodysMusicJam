using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fruits
{
    public class MelodysMusicJam
    {
        public int UserID;
        public int OrderID;
        public int EventID;
        public int TicketTypeID;

        public void CheckUser()
        {
            throw new System.NotImplementedException();
        }
    }

    public class User : MelodysMusicJam
    {
        private string Name;
        private string EmailID;
    }

    public class Concert : MelodysMusicJam
    {
        private string City;
        private DateOnly Date;
        private TimeOnly Time;

        public void GetConcertInfo()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Tickets : Concert
    {
        private int SeatLocation;
        private int Price;

        public void GetTicketsInfo()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Order : Concert
    {
        private int TicketID;
        private int Price;

        public void NotifyUser()
        {
            throw new System.NotImplementedException();
        }

        public void Payment()
        {
            throw new System.NotImplementedException();
        }

        public void CalculatePrice()
        {
            throw new System.NotImplementedException();
        }
    }
}