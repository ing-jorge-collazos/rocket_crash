using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float rocketVelocity = 100f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

     void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * rocketVelocity * Time.deltaTime); //Es lo mismo que (0,1,0) vector3.up abrevia
        }
    }

    void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Rotate Left");
        }

        else if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Rotate Right");
        }
    }
}
