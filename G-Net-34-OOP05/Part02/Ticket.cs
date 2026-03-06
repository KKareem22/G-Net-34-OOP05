using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP05.Part02
{
    internal class Ticket :IPrintable ,IBookable
    {
		private string _movieName;
		private decimal _price;
        public int TicketID { get; }
		private static int _ticketCounter = 0;

        public Ticket(string moiveName, decimal price)
        {
            MovieName = moiveName;
            Price = price;
			_ticketCounter++;
			TicketID = _ticketCounter;
        }

        public string MovieName
		{
			get { return _movieName; }
			set
			{
				if(!string.IsNullOrWhiteSpace(value)) _movieName = value;
			}
		}
		public decimal Price
		{
			get { return _price; }
			set
			{
				if(value>0) _price = value;
			}
		}
        public virtual decimal PriceAfterTax => Price * 1.14m;

        public bool IsBooked { get; private set; }

        public override string ToString()
        {
			return $"[Ticket #{TicketID}]|Movie: {MovieName}| Price: {Price:F2} EGP| After Tax: {PriceAfterTax:F2} EGP";
        }
		public static int GetTicketCounter()=> _ticketCounter;


        public void BookTicket()
        {
            if (IsBooked)
                return;
            else
            {
                IsBooked = true;

            }
        }

        public void CancleBookTicket()
        {
            if(!IsBooked)
            {
                return;
            }
            else
            {
                IsBooked = false;
                
            }
        }

        public void PrintDetails()
        {
            string status = IsBooked ? "Yes" : "No";
            Console.WriteLine($"{ToString()} |Booked :{status}\n");
        }
    }
}
