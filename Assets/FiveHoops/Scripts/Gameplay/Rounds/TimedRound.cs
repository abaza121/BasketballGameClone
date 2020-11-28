

namespace FiveHoops.Gameplay.Rounds
{
    /// <summary>
    /// This is an example round where a timer shows up and the player throws as many balls in that time. (to be implemented).
    /// </summary>
    public class TimedRound : Round
    {
        private int roundTimeInSeconds;

        public TimedRound(int timeInSeconds, Throwable throwable, Thrower thrower) : base(throwable, thrower)
        {
            roundTimeInSeconds = timeInSeconds;
        }
    }
}
