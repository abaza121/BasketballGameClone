using FiveHoops.Managers;
using UnityEngine;

namespace FiveHoops.Managers
{
    /// <summary>
    /// Responsible for managing score progression and Data.
    /// </summary>
    public class ScoreManager : MonoBehaviour
    {
        public int CurrentScore
        {
            get;
            set;
        }

        public void ScoredPoint()
        {
            CurrentScore++;
            GameManager.Instance.UIManager.UpdateShownScore(CurrentScore);
        }

        public void ResetCurrentScore()
        {
            CurrentScore = 0;
            GameManager.Instance.UIManager.UpdateShownScore(CurrentScore);
        }
    }
}
