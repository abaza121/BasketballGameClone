using UnityEngine;

namespace FiveHoops.Gameplay.Rounds
{
    /// <summary>
    /// Builds the round based on the needed Type.
    /// </summary>
    public class RoundBuilder : MonoBehaviour
    {
        public Round CreateRound(Throwable throwable, Thrower thrower)
        {
            return new Round(throwable, thrower);
        }
    }
}
