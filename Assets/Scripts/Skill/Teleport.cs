namespace Script.TeleportSkill
{
    using UnityEngine;
    public class Teleport : MonoBehaviour
    {
        private float distanceTeleport = 4f;
        
        private void Update()
        {
            TeleportLeft();
            TeleportRight();
        }

        private void TeleportLeft()
        {
            if(Input.GetKeyDown(KeyCode.Q)) { transform.position -= transform.right * distanceTeleport; }
        }
        private void TeleportRight()
        {
            if(Input.GetKeyDown(KeyCode.E)) { transform.position += transform.right * distanceTeleport; }
        }
    }    
}