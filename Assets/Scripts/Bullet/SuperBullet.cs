namespace Script.BulletNumberTwo
{
    using UnityEngine;

    public class SuperBullet : MonoBehaviour
    {
        private float speed = 100f;
        private float timeStart = 3f;
        private float lifeTimer;
        private float timeStop = 0f;
        
        private void Start()
        {
            SetTimer();
        }

        private void Update()
        {
            MoveBullet();
            SetTimerDestroyBullet();            
        }

        private void SetTimer() { lifeTimer = timeStart; }

        private void MoveBullet() { transform.position += transform.forward * speed * Time.deltaTime; }

        private void SetTimerDestroyBullet()
        {
            lifeTimer -= Time.deltaTime;
            if(lifeTimer <= timeStop) { Destroy(gameObject); }  
        }
    }   
}
