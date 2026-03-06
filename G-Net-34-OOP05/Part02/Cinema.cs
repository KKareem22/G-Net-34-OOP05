using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP05.Part02
{
    internal class Cinema
    {
        private List<IPrintable> _printables=new List<IPrintable>();
        public void AddTicket(IPrintable printable)
        {
            _printables.Add(printable);
        }
        public void PrintAllTickets()
        {
            Console.WriteLine("=======Print All=======");
            foreach (var p in _printables)
            {
                if (p != null)
                    p.PrintDetails();
            }
        }
        public void OpenCinema()=> Console.WriteLine("=======Cinema Opened=======");


        public void CloseCinema()=> Console.WriteLine("=======Cinema Closed=======");

    }
}
