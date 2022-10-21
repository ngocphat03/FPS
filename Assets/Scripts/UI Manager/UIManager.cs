
    using UnityEngine;
    using UnityEngine.UI;
    using UnityEngine.SceneManagement;

    public class UIManager : MonoBehaviour
    {
        [SerializeField] private GameObject SettingPopup;
        [SerializeField] private GameObject TutorialPopup;
        [SerializeField] private GameObject GameOverPopup;
        [SerializeField] private GameObject GameWinPopup;

        public static UIManager Instance {get; private set;}

        private void Awake() { Instance = this; }

        public void PlayButton() { SceneManager.LoadScene("Main"); }

        public void SettingButton() { SettingPopup.SetActive(true); }

        public void CloseSettingPopup() { SettingPopup.SetActive(false); }

        public void ButtonTutorial() { TutorialPopup.SetActive(true); }

        public void CloseTutorialPopup() { TutorialPopup.SetActive(false); }

        public void GameOver() { GameOverPopup.SetActive(true); }

        public void GameWin() { GameWinPopup.SetActive(true); }

        public void Reload() { Time.timeScale = 1f; SceneManager.LoadScene(0); }
    }
