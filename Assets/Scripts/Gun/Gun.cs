namespace Script.GunNumberOne
{
     using UnityEngine;

     public class Gun : MonoBehaviour
     {
          [SerializeField] private Transform bulletSpawnPoint;
          [SerializeField] private Camera playerCamera;
          [SerializeField] private GameObject bullerPrefab;

          private void Update()
          {
              Shooting();
          }
          private void Shooting()
          {
               if(Input.GetMouseButtonDown(0))
               {
                    GameObject bulletObject = Instantiate(bullerPrefab);
                    bulletObject.transform.position = bulletSpawnPoint.transform.position + playerCamera.transform.forward;
                    bulletObject.transform.forward = playerCamera.transform.forward;
               }
          }
     }
}