using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP05.Part02
{
    internal static class BookingHelper
    {
        public static void PrintAnything(IPrintable[] printable)
        {
            Console.WriteLine("=======BookingHelper.PrintAll=======");
            foreach(var item in printable)
            {
                item.PrintDetails();
            }
        }


    }
}
