
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float speed = 1f;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            Debug.Log("HIii0");
            transform.position += transform.forward * speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }

        // ShootRaycast();

        // if(Input.GetKeyDown(KeyCode.Space) & grounded == true)
        // {
        //     rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
        // }

        // float h = horizontalSpeed * Input.GetAxis("Mouse X");
        // transform.Rotate(v, h, 0);

    }

    // void ShootRaycast()
    // {
    //     RaycastHit hit;
    //     if(Physics.Raycast(GroundedCam.transform.position, GroundedCam.transform.forward, out hit, range))
    //     {
    //         Debug.Log(hit.transform.name);
            
    //         Target target = hit.transform.GetComponent<Target>();
    //         if (target != null)
    //         {
    //             StartCoroutine(JumpBool());
    //         }
    //     }
    // }

    // IEnumerator JumpBool()
    // {
    //     grounded = true;
    //     yield return new WaitForSeconds(0.1f);
    //     grounded = false;
    // }
}