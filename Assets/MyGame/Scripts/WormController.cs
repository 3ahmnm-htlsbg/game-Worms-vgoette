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
    public Vector3 jump;
    public Vector3 move;


    void Update()
    {
        //transform Player

        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(move);
            rb.AddForce(jump);

        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(-move);
            rb.AddForce(jump);

        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce (jump);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject sphere = Instantiate(weapon, bulletPosition.position, Quaternion.identity);
            sphere.GetComponent<Rigidbody>().AddForce(bazooka.transform.up * shoot);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            bazooka.transform.Rotate(0, 0, -5, Space.Self);
            Debug.Log("Button Input detected");
        }

        if (Input.GetKey(KeyCode.E))
        {
            bazooka.transform.Rotate(0, 0, 5, Space.Self);
            Debug.Log("Button Input detected");
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
