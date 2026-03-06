using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP05.Part02
{
    internal class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }
        public VIPTicket(string movieName, decimal price, bool loungeAccess) : base(movieName, price)
        {
            LoungeAccess = loungeAccess;
        }
        public decimal ServiceFee = 50m;
        public override decimal PriceAfterTax => base.PriceAfterTax + ServiceFee; // VIP tickets have an additional  after tax fee of $50
        public override string ToString()
        {
            return $"[Ticket #{TicketID}] {MovieName} | VIP | Lounge Access : {(LoungeAccess ? "Yes" : "No")} | ServiceFee :{ServiceFee:F2} EGP |Price :{Price} EGP | After Tax:{PriceAfterTax}";
        }

    }
}
