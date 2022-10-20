namespace Script.AutoFire
{
    using UnityEngine;

    public class AutoFire : MonoBehaviour
    {
        [SerializeField] private GameObject bullerPrefab;
        [SerializeField] private Transform bulletSpawnPoint;
        [SerializeField] private float timeStart = 3f;
        [SerializeField] private Transform Player;

        void Start()
        {
            InvokeRepeating("SetTimerToFire", 2.0f, 0.3f);
        }
        private void SetTimerToFire()
        {
            GameObject bulletObject = Instantiate(bullerPrefab, bulletSpawnPoint.transform.position, transform.rotation);
        //    bulletObject.transform.LookAt(Player);
        //    bulletObject.transform.position = bulletSpawnPoint.transform.position;
           bulletObject.transform.LookAt(Player);
        }
    }    
}