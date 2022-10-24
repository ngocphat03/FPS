    using UnityEngine;
    using UnityEngine.UI;
    using UnityEngine.SceneManagement;

    public class UIManager : MonoBehaviour
    {
        private GameObject SettingPopup;
        private GameObject TutorialPopup;
        private GameObject ExitPopup;
        private GameObject GamePopup;
        private int Test = 1;

        public static UIManager Instance {get; private set;}

        private void FixedUpdate() {OpenSettingPopupWithKey();}

        private void Awake() 
        {
            Instance = this; 
        }

        public void PlayButton() { SceneManager.LoadScene("Main"); }

        public void SettingButton() { Instantiate(Resources.Load<GameObject>("UI/PopupSetting") as GameObject); }

        public void CloseSettingPopup() 
        { 
            SettingPopup = GameObject.FindWithTag("SettingPopup"); 
            Destroy(SettingPopup); GameManager.Instance.StartGame(); 
        }

        public void OpenSettingPopupWithKey() 
        { 
            if(Input.GetKey(KeyCode.Escape)) 
            {
                SettingButton(); 
                GameManager.Instance.StopGame(); 
            }
        }

        public void ButtonTutorial() 
        {
            Instantiate(Resources.Load<GameObject>("UI/PopupTutorial") as GameObject); 
            GameManager.Instance.StopGame(); 
        }

        public void CloseTutorialPopup() 
        { 
            TutorialPopup = GameObject.FindWithTag("TutorialPopup"); 
            Destroy(TutorialPopup); GameManager.Instance.StartGame(); 
        }

        public void GameOver() 
        { 
            if(Test == 1) {Instantiate(Resources.Load<GameObject>("UI/PopupGameOver") as GameObject); Test = 0;} 
        }

        public void GameWin() 
        { 
            if(Test == 1) {Instantiate(Resources.Load<GameObject>("UI/PopupGameWin") as GameObject); Test = 0;} 
        }

        public void CloseGamePopup() 
        { 
            GamePopup = GameObject.FindWithTag("GameWinLosePopup"); 
            Destroy(ExitPopup); 
            Test = 1;
        }

        public void Reload() { Time.timeScale = 1f; SceneManager.LoadScene(0); }

        public void ButtonExit() { Instantiate(Resources.Load<GameObject>("UI/PopupExit") as GameObject); }

        public void CloseExitPopup() 
        { 
            ExitPopup = GameObject.FindWithTag("ExitPopup"); 
            Destroy(ExitPopup); 
        }

        public void QuitGame() { Application.Quit(); }

    }
