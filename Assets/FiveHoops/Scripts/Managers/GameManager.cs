using UnityEngine;

namespace FiveHoops.Managers
{
    /// <summary>
    /// Controls game start and end.
    /// </summary>
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;
        
        public UIManager UIManager;
        public GameplayManager GameplayManager;
        public ScoreManager ScoreManager;

        [SerializeField]
        private float gameplayTimeScale = 2.5f;

        public void StartGame()
        {
            ScoreManager.ResetCurrentScore();
            UIManager.ShowPanel(PanelType.InGame);
            UIManager.HidePanel(PanelType.MainMenu);
            GameplayManager.StartNewGame();
            Time.timeScale = gameplayTimeScale;
        }

        public void ResumeGame()
        {
            UIManager.HidePanel(PanelType.Pause);
            Time.timeScale = gameplayTimeScale;
        }

        public void RestartGame()
        {
            SwipeDetector.ClearOnSwipeListeners();
            ScoreManager.ResetCurrentScore();
            GameplayManager.StartNewGame();

            UIManager.ShowPanel(PanelType.InGame);
            UIManager.HidePanel(PanelType.GameOver);

            Time.timeScale = gameplayTimeScale;
        }

        public void PauseGame()
        {
            UIManager.ShowPanel(PanelType.Pause);
            Time.timeScale = 0;
        }

        public void GameOver()
        {
            UIManager.UpdateGameOverPanel(ScoreManager.CurrentScore);
            UIManager.ShowPanel(PanelType.GameOver);
            Time.timeScale = 0;
        }

        private void Awake()
        {
            Instance = this;
            UIManager.ShowPanel(PanelType.MainMenu);
        }
    }
}
