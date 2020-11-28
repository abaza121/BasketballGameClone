using FiveHoops.Gameplay;
using FiveHoops.Gameplay.Rounds;
using UnityEngine;

namespace FiveHoops.Managers
{
    /// <summary>
    /// Responible for starting the rounds and handling its end.
    /// </summary>
    public class GameplayManager : MonoBehaviour
    {
        [SerializeField]
        private RoundBuilder roundBuilder;
        [SerializeField]
        private Thrower thrower;
        [SerializeField]
        private Throwable throwable;

        private Round currentRound;

        // Start is called before the first frame update
        private void Start()
        {
            StartNewRound();
        }

        private void OnRoundEnded()
        {
            StartNewRound();
        }

        private void StartNewRound()
        {
            currentRound = roundBuilder.CreateRound(throwable, thrower);
            currentRound.StartRound();
            currentRound.RoundEnded += OnRoundEnded;
        }
    }
}
