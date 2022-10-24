namespace Script.PlayerView
{
    using UnityEngine;
    using UnityEngine.UI;
    using Ensign;
    using Ensign.Unity.MVC;
    using Script.PlayerModel;
    using Script.PlayerController;
    public class PlayerView : View<PlayerController, PlayerModel>
    {
        [SerializeField] private Slider SliderHealth;

        private void Awake()
        {
            HideMouse();
        }

        private void Update()
        {
            PlayerMove();
            MovePlayerCameraWithMouse();
            SetHealth();
            PlayerDie();
            Check();
        }

        /// <summary>
        /// Move player with AWSD
        /// </summary>
        public void PlayerMove()
        {
            //Move player to top
            if(Input.GetKey(KeyCode.W)) { transform.position += transform.forward * this.Model.speed * Time.deltaTime; }
            //Move player to bottom
            if(Input.GetKey(KeyCode.S)) { transform.position -= transform.forward * this.Model.speed * Time.deltaTime; }
            //Move player to right
            if(Input.GetKey(KeyCode.D)) { transform.position += transform.right * this.Model.speed * Time.deltaTime; }
            //Move player to left
            if(Input.GetKey(KeyCode.A)) { transform.position -= transform.right * this.Model.speed * Time.deltaTime; }
        }

        private void MovePlayerCameraWithMouse()
        {
            if(GameManager.Instance.CanMovePlayerCamera)
            {
                this.Model.rotationX = Input.GetAxis("Mouse Y");
                this.Model.rotationY = Input.GetAxis("Mouse X");
                transform.eulerAngles -= new Vector3(this.Model.rotationX * this.Model.sensitivity,this.Model.rotationY* -1f * this.Model.sensitivity,0);
            }            
        }
        /// <summary>
        /// Hide mouse
        /// </summary>
        private void HideMouse() { Cursor.lockState = CursorLockMode.Locked; }

        void OnTriggerEnter (Collider myTrigger) 
        {
            if(myTrigger.gameObject.tag == "Bullet")
            {
                this.Model.damageTaken = 5;
                this.Controller.SubtractHealth();
            }

            if(myTrigger.gameObject.tag == "BulletPlus")
            {
                this.Model.damageTaken = 30;
                this.Controller.SubtractHealth();
            }
        }   

        private void PlayerDie() 
        {
            if(this.Model.health <= 0)
            {
                GameManager.Instance.GameOver();
            }
        }

        private void Check()
        {
            if(transform.position.y < -10)
            {
                transform.position = new Vector3(10, 5, -30);
            }
        }
        
        /// <summary>
        /// Change health bar
        /// </summary>
        public void SetHealth() { SliderHealth.value = this.Model.health; }
    }    
}