using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP05.Part01.UsingQ02
{
    internal class Translator : IEnglishSpeaker, IArabicSpeaker
    {
        void IEnglishSpeaker.Greet() => Console.WriteLine("Hello");      

        void IArabicSpeaker.Greet() => Console.WriteLine("Ahlan");

    }
}
