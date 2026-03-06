using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP05.Part02
{
    internal class IMAXTicket:Ticket
    {
        public bool Is3D { get; set; }
        public IMAXTicket(string movieName, decimal price, bool is3D) : base(movieName, price)
        {
            Is3D = is3D;
        }
        public override decimal PriceAfterTax => Is3D ? base.PriceAfterTax + 30m : base.PriceAfterTax;
        public override string ToString()
        {
            return $"[Ticket #{TicketID}] {MovieName} | {this.GetType().Name.Replace("Ticket", "")} | IMAX 3D :{(Is3D ? "Yes" : "No")} | After Tax:{PriceAfterTax}";
        }
    }
}
