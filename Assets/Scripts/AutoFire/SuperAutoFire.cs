namespace Script.SuperAutoFire
{
    using UnityEngine;

    public class SuperAutoFire : MonoBehaviour
    {
        [SerializeField] private GameObject bullerPrefab;
        [SerializeField] private Transform bulletSpawnPoint;
        [SerializeField] private Transform Player;


        void Start()
        {
            InvokeRepeating("SetTimerToFire", 2.0f, Random.Range(2, 5));
        }
        private void SetTimerToFire()
        {
            GameObject bulletObject = Instantiate(bullerPrefab, bulletSpawnPoint.transform.position, transform.rotation);
            bulletObject.transform.LookAt(Player);
        }
    }    
}