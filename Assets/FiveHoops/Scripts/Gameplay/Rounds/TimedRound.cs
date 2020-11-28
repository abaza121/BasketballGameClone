using FiveHoops.Managers;
using System.Collections;
using UnityEngine;

namespace FiveHoops.Gameplay.Rounds
{
    /// <summary>
    /// This is an example round where a timer shows up and the player throws as many balls in that time. (to be implemented).
    /// </summary>
    public class TimedRound : Round
    {
        private int roundTimeInSeconds;

        public TimedRound(int timeInSeconds, Throwable throwable, Thrower thrower, PositionPicker positionPicker) : base(throwable, thrower, positionPicker)
        {
            roundTimeInSeconds = timeInSeconds;
        }

        public override void StartRound()
        {
            SetNewPosition();
            GameManager.Instance.StartCoroutine(WaitThenEnd());
            throwable.TouchedGround += SetNewPosition;
        }

        public override void EndRound()
        {
            throwable.TouchedGround -= SetNewPosition;
            InvokeEndRound();
        } 

        private IEnumerator WaitThenEnd()
        {
            float time = 0;
            while(time < roundTimeInSeconds)
            {
                time += Time.unscaledDeltaTime;
                GameManager.Instance.UIManager.UpdateShownTime(time);
                yield return null;
            }

            EndRound();
        }
    }
}
