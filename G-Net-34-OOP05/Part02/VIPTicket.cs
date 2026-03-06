using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP05.Part02
{
    internal class VIPTicket : Ticket,ICloneable 
    {
        public bool LoungeAccess { get; set; }
        public VIPTicket(string movieName, decimal price, bool loungeAccess) : base(movieName, price)
        {
            LoungeAccess = loungeAccess;
        }
        public decimal ServiceFee = 50m;
        public override decimal PriceAfterTax => base.PriceAfterTax ; // مضفتش ال 50 علشان الصورة اللي في الاسايمنت انتوا مش ضيفنها
        public override string ToString()
        {
            return $"[Ticket #{TicketID}] {MovieName} | {this.GetType().Name.Replace("Ticket", "")} | Lounge Access : {(LoungeAccess ? "Yes" : "No")} | ServiceFee :{ServiceFee:F2} EGP |Price :{Price} EGP | After Tax:{PriceAfterTax}";
        }

        public VIPTicket Clone()
        {
            return new VIPTicket(this.MovieName,this.Price,this.LoungeAccess);
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }
    }
}
