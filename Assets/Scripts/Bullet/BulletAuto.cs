namespace Script.BulletAuto
{
    using UnityEngine;

    public class BulletAuto : MonoBehaviour
    {
        [SerializeField] private Transform Player;
        [SerializeField] private float speed = 10f;
        [SerializeField] private float timeStart = 3f;
        private float lifeTimer;
        private float timeStop = 0f;
        
        private void Start()
        {
            SetTimer();
        //    Player = transform.GetComponent("Player");
            transform.LookAt(Player);
        }

        private void Update()
        {
            MoveBullet();
         //   SetTimerDestroyBullet();            
        }

        private void SetTimer() { lifeTimer = timeStart; }

   //     private void MoveBullet() { transform.position += transform.forward * speed * Time.deltaTime; }
        private void MoveBullet() { 
            transform.position += transform.forward * speed * Time.deltaTime; }

        private void SetTimerDestroyBullet()
        {
            lifeTimer -= Time.deltaTime;
            if(lifeTimer <= timeStop) { Destroy(gameObject); }  
        } 
        // A is Enemy
        public Transform Enemy;
        // B is Player
        
        // Vector AB = Vector B - Vector A
        private Transform bulletDirection;

        private void bullet()
        {
            bulletDirection.transform.position = Player.transform.position - Enemy.transform.position;
        }
        
    }   
}
