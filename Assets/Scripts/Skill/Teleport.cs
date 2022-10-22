namespace Script.TeleportSkill
{
    using UnityEngine;
    using System.Collections;
    public class Teleport : MonoBehaviour
    {
        [SerializeField] private GameObject Prefab;
        private float distanceTeleport = 15f;
        //<==== Timer====>
        [SerializeField] private float timeStart = 0.5f;
        private float lifeTimer;
        private float timeStop = 0f;


        private void Start()
        {
            SetTimer();
        }
        private void Update()
        {
            TeleportLeft();
            TeleportRight();
            TurnOnEffect();
        }

        private void FixedUpdate()
        {
            TurnOffEffect();
        }

        private void TeleportLeft()
        {
            if(Input.GetKeyDown(KeyCode.Q)) { transform.position -= transform.right * distanceTeleport; }
        }
        private void TeleportRight()
        {
            if(Input.GetKeyDown(KeyCode.E)) { transform.position += transform.right * distanceTeleport; }
        }

        private void SetTimer() { lifeTimer = timeStart; }

        /// <summary>
        /// Turn on teleport effect
        /// </summary>
        private void TurnOnEffect()
        {
            if(Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.E)) 
            { 
                Prefab.SetActive(false);
                Prefab.SetActive(true);
            }
        }

        /// <summary>
        /// Turn on teleport effect
        /// </summary>
        private void TurnOffEffect()
        {
            if(Prefab.active == true)
            {
                lifeTimer -= Time.deltaTime;
                if(lifeTimer <= timeStop) { Prefab.SetActive(false);  SetTimer(); } 
            }
        }
    }    
}