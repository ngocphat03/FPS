    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;

    public class GameManager : MonoBehaviour
    {
        public bool CanMovePlayerCamera;
        public static GameManager Instance {get; private set;}
        public float sensitivityMouse = 2.5f;
        [SerializeField] private Slider SliderSensitivityMouse;
        private void Awake()
        {
            Instance = this;
        }
        void Start()
        {
            Time.timeScale = 1f;
        }
        void Update()
        {
            
        }

        public void StopGame()
        {
            Time.timeScale = 0f;
            CanMovePlayerCamera = false;
            Cursor.lockState = CursorLockMode.Confined;
        }

        public void StartGame()
        {
            Time.timeScale = 1f;
            CanMovePlayerCamera = true;
            Cursor.lockState = CursorLockMode.Locked;
        }

        public void GameOver()
        {
            StopGame();
            UIManager.Instance.GameOver();
        }

        public void GameWin()
        {
            StopGame();
            UIManager.Instance.GameWin();
        }

        public void ChangeSensitivityMouse()
        {
            sensitivityMouse = SliderSensitivityMouse.value;
        }
    }    