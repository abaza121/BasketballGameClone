using System;

namespace FiveHoops.Gameplay.Rounds
{
    /// <summary>
    /// Round base class, this is the default round that ends once the ball has touched the ground.
    /// </summary>
    public class Round
    {
        public event Action RoundEnded;
        private Throwable throwable;
        private Thrower thrower;

        public Round(Throwable throwable, Thrower thrower)
        {
            this.throwable = throwable;
            this.thrower = thrower;
        }

        public void StartRound()
        {
            throwable.TouchedGround += EndRound;
            thrower.LoadThrowable(throwable);
        }

        public void EndRound()
        {
            throwable.TouchedGround -= EndRound;
            RoundEnded.Invoke();
        }
    }
}
