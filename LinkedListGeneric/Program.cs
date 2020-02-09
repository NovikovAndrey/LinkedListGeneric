using System;
using Separator;

namespace LinkedListGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleSeparator consoleSeparator = new ConsoleSeparator('-', 50);
            SeparateEvent separateEvent = new SeparateEvent();
            separateEvent.OnSeparate += consoleSeparator.Separator;
            

        }
    }
}
