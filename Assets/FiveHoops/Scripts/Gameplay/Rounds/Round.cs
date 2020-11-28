using System;
using UnityEngine.UIElements;

namespace FiveHoops.Gameplay.Rounds
{
    /// <summary>
    /// Round base class, this is the default round that ends once the ball has touched the ground.
    /// </summary>
    public class Round
    {
        public event Action RoundEnded;
        protected Throwable throwable;
        protected Thrower thrower;

        private PositionPicker positionPicker;

        public Round(Throwable throwable, Thrower thrower, PositionPicker positionPicker)
        {
            this.throwable = throwable;
            this.thrower = thrower;
            this.positionPicker = positionPicker;
        }

        public virtual void StartRound()
        {
            throwable.TouchedGround += EndRound;
            SetNewPosition();
        }

        public virtual void EndRound()
        {
            throwable.TouchedGround -= EndRound;
            InvokeEndRound();
        }

        protected void SetNewPosition()
        {
            var pickedTransform = positionPicker.PickRandomPosition();
            thrower.transform.position = pickedTransform.position;
            thrower.transform.rotation = pickedTransform.rotation;
            thrower.LoadThrowable(throwable);
        }

        protected void InvokeEndRound()
        {
            RoundEnded.Invoke();
        }
    }
}
