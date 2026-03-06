using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP05.Part02
{
    internal interface IBookable
    {
        bool IsBooked { get; }
        void BookTicket();
        void CancleBookTicket();
    }
}
