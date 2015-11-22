using System;

namespace Model
{
    public class Numbertron
    {
        public event EventHandler<EventArgsNewNumber> NewNumber;

        public void Generate(Random rnd)
        {
            var number = rnd.Next(0, 100);
            NewNumber?.Invoke(this, new EventArgsNewNumber(number));

        }
    }
}
