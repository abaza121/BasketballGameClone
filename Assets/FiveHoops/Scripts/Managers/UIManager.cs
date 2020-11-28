using TMPro;
using UnityEngine;

namespace FiveHoops.Managers
{
    /// <summary>
    /// Responsible for managing all UI interactions.
    /// </summary>
    public class UIManager : MonoBehaviour
    {
        [SerializeField]
        private TextMeshProUGUI scoreLabel;

        [SerializeField]
        private TextMeshProUGUI timeLabel;

        [SerializeField]
        private TextMeshProUGUI gameOverScoreLabel;

        [SerializeField]
        private GameObject inGamePanel;

        [SerializeField]
        private GameObject mainMenuPanel;

        [SerializeField]
        private GameObject pausePanel;

        [SerializeField]
        private GameObject gameOverPanel;

        public void ShowPanel(PanelType panelType)
        {
            ChangePanelState(panelType, true);
        }

        public void HidePanel(PanelType panelType)
        {
            ChangePanelState(panelType, false);
        }

        public void StartButtonPressed()
        {
            GameManager.Instance.StartGame();
        }

        public void RestartButtonPressed()
        {
            GameManager.Instance.RestartGame();
        }

        public void ResumeButtonPressed()
        {
            GameManager.Instance.ResumeGame();
        }

        public void PauseButtonPressed()
        {
            GameManager.Instance.PauseGame();
        }

        public void UpdateShownScore(int score)
        {
            scoreLabel.text = string.Format("Score: {0}", score);
        }

        public void UpdateShownTime(float time)
        {
            timeLabel.text = string.Format("Time: {0:0.00}", time);
        }

        public void UpdateGameOverPanel(int score)
        {
            gameOverScoreLabel.text = string.Format("Score: {0}", score);
        }

        private void ChangePanelState(PanelType panelType, bool state)
        {
            switch (panelType)
            {
                case PanelType.MainMenu:
                    mainMenuPanel.SetActive(state);
                    break;
                case PanelType.InGame:
                    inGamePanel.SetActive(state);
                    break;
                case PanelType.Pause:
                    pausePanel.SetActive(state);
                    break;
                case PanelType.GameOver:
                    gameOverPanel.SetActive(state);
                    break;
            }
        }
    }
}

public enum PanelType
{
    MainMenu,
    InGame,
    Pause,
    GameOver
}
