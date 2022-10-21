    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class GameManager : MonoBehaviour
    {
        public bool CanMovePlayerCamera;
        public static GameManager Instance {get; private set;}
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

        private void Stop()
        {
            Time.timeScale = 0f;
            CanMovePlayerCamera = false;
            Cursor.lockState = CursorLockMode.Confined;
        }
        public void GameOver()
        {
            Stop();
            UIManager.Instance.GameOver();
        }

        public void GameWin()
        {
            Stop();
            UIManager.Instance.GameWin();
        }
    }    