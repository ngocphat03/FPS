namespace Script.LookAtForObject
{
    using UnityEngine;

    public class LookAtForObject : MonoBehaviour
    {
        [SerializeField] private Transform LookAtFor;

        void Update()
        {
            transform.LookAt(LookAtFor);
            transform.Rotate(0,180,0);
        }
    }
}