
    using UnityEngine;
    using UnityEngine.UI;
    using UnityEngine.SceneManagement;

    public class UIManager : MonoBehaviour
    {
        private GameObject SettingPopup;
        private GameObject TutorialPopup;
        private GameObject ExitPopup;
        [SerializeField] private GameObject GameOverPopup;
        [SerializeField] private GameObject GameWinPopup;

        public static UIManager Instance {get; private set;}

        private void FixedUpdate() {OpenSettingPopupWithKey();}

        private void Awake() 
        {
            Instance = this; 
        }

        public void PlayButton() { SceneManager.LoadScene("Main"); }

        public void SettingButton() { Instantiate(Resources.Load<GameObject>("UI/PopupSetting") as GameObject); }

        public void CloseSettingPopup() { SettingPopup = GameObject.FindWithTag("SettingPopup"); Destroy(SettingPopup); }

        public void OpenSettingPopupWithKey() { if(Input.GetKey(KeyCode.Escape)) SettingButton(); }

        public void ButtonTutorial() { Instantiate(Resources.Load<GameObject>("UI/PopupTutorial") as GameObject); }

        public void CloseTutorialPopup() { TutorialPopup = GameObject.FindWithTag("TutorialPopup"); Destroy(TutorialPopup); }

        public void GameOver() { GameOverPopup.SetActive(true); }

        public void GameWin() { GameWinPopup.SetActive(true); }

        public void Reload() { Time.timeScale = 1f; SceneManager.LoadScene(0); }

        public void ButtonExit() { Instantiate(Resources.Load<GameObject>("UI/PopupExit") as GameObject); }

        public void CloseExitPopup() { ExitPopup = GameObject.FindWithTag("ExitPopup"); Destroy(ExitPopup); }

        public void QuitGame() { Application.Quit(); }

    }
