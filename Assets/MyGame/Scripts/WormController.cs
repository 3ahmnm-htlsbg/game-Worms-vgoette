using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
    public Rigidbody rb;
    public float Speed;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //transform Player

        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(transform.right * Speed);
            rb.AddForce(transform.up * Speed);
        }

       if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(-transform.right * Speed);
            rb.AddForce(transform.up * Speed);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(transform.up * Speed);
        }

        
        
    }

    


    /*void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Wird aufgerufen!");
        }
    }*/
}
