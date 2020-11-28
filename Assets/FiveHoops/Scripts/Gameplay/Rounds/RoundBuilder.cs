using UnityEngine;

namespace FiveHoops.Gameplay.Rounds
{
    /// <summary>
    /// Builds the round based on the needed Type.
    /// </summary>
    public class RoundBuilder : MonoBehaviour
    {
        [SerializeField]
        private PositionPicker positionPicker;
        [SerializeField]
        private Thrower thrower;
        [SerializeField]
        private Throwable throwable;


        public Round CreateRound()
        {
            return new Round(throwable, thrower, positionPicker);
        }

        public Round CreateTimedRound(int timeInSeconds)
        {
            return new TimedRound(timeInSeconds, throwable, thrower, positionPicker);
        }
    }
}
