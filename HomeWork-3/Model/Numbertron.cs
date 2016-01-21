using System;

namespace Model
{
    public class Numbertron
    {
        Random rnd=new Random();

        public event EventHandler<EventArgsNewNumber> NewNumber;

        public void Generate()
        {
            int number = rnd.Next(100);
            NewNumber?.Invoke(this, new EventArgsNewNumber(number));
        }
    }
}
