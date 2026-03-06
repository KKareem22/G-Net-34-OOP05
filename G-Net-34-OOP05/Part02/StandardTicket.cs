using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP05.Part02
{
    internal class StandardTicket : Ticket
    {
        public string SeatNumber { get; set; }
        public StandardTicket(string movieName, decimal price, string seatNumber) : base(movieName, price)
        {
            SeatNumber = seatNumber;
        }
        public override string ToString()
        {
            return $"[Ticket #{TicketID}] {MovieName} | Standard | Seat:{SeatNumber} |Price :{Price} EGP | After Tax:{PriceAfterTax}";
        }
    }
}
