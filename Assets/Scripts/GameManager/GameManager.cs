namespace Script.GameManager
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;
        private void Awake()
        {
            Instance = this;
        }
        void Start()
        {
            
        }
        void Update()
        {
            
        }
        public static void GameOver()
        {
            Time.timeScale = 0f;
        }
    }    
}

