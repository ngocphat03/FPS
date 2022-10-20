namespace Script.PlayerView
{
    using UnityEngine;
    using Ensign;
    using Ensign.Unity.MVC;
    using Script.PlayerModel;
    using Script.PlayerController;
    public class PlayerView : View<PlayerController, PlayerModel>
    {
        private void Awake()
        {
            HideMouse();
        }

        private void Update()
        {
            PlayerMove();
            MovePlayerCameraWithMouse();
        }
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
            this.Model.rotationX = Input.GetAxis("Mouse Y");
            this.Model.rotationY = Input.GetAxis("Mouse X");
            transform.eulerAngles -= new Vector3(this.Model.rotationX * this.Model.sensitivity,this.Model.rotationY* -1f * this.Model.sensitivity,0);
        }
        /// <summary>
        /// Hide mouse
        /// </summary>
        private void HideMouse() { Cursor.lockState = CursorLockMode.Locked; }
    }    
}