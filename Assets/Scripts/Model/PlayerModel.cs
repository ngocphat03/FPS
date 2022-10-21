namespace Script.PlayerModel
{
    using Ensign;
    using UnityEngine;
    public class PlayerModel : IDataModel
    {
        //<====Player camera====>
        public float rotationX;
        public float rotationY; 
        public float sensitivity;
        //<====Player movement====>
        public float speed;
        //<====Player data====>
        public float health;
        public float damageTaken;
    }    
}