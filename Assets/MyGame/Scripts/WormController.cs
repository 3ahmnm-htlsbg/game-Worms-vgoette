using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
    public Rigidbody rb;
    public float Speed;
    public GameObject weapon;
    public GameObject bazooka;
    public float shoot = 100;
    public Transform bulletPosition;


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


        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject sphere = Instantiate(weapon, bulletPosition.position, Quaternion.identity);
            sphere.GetComponent<Rigidbody>().AddForce(bazooka.transform.up * shoot);
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
