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
        private int roundTimeInSeconds;

        private Round currentRound;

        public void StartNewGame()
        {
            StartNewRound();
        }

        private void OnRoundEnded()
        {
            GameManager.Instance.GameOver();
        }

        private void StartNewRound()
        {
            currentRound = roundBuilder.CreateTimedRound(roundTimeInSeconds);
            currentRound.StartRound();
            currentRound.RoundEnded += OnRoundEnded;
        }
    }
}
