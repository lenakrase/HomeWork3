using System;

namespace Model
{
    public class EventArgsNewNumber : EventArgs
    {
        
        public EventArgsNewNumber(int number)
        {
            Number = number;
        }

        public int Number { get; }
    }
}
