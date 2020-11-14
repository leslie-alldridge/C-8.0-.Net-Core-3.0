using static System.Console;

namespace Packt.Shared
{
    public class DvdPlayer : IPlayable
    {
        public void Pause()
        {
            WriteLine("Dvd Player is pausing!");
        }

        public void Play()
        {
            WriteLine("Dvd Player is playing!");
        }
    }
}