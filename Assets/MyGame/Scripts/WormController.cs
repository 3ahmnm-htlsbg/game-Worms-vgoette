using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public int health = 10;
    public Text healthText;

    public Transform player;
    public Transform respawnPoint;

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
            rb.AddForce(jump);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject sphere = Instantiate(weapon, bulletPosition.position, Quaternion.identity);
            sphere.GetComponent<Rigidbody>().AddForce(bazooka.transform.forward * shoot);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            bazooka.transform.Rotate(-5, 0, 0, Space.Self);
            Debug.Log("Button Input detected");
        }

        if (Input.GetKey(KeyCode.E))
        {
            bazooka.transform.Rotate(5, 0, 0, Space.Self);
            Debug.Log("Button Input detected");
        }

        DisplayHealth();
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "damagezone")
        {
            health = health - 1;
            Debug.Log("Kollision DamageZone");

        }

        else
        {
            Debug.Log("Andere Kollision");
        }

        if (collision.gameObject.tag == "healthpackage")
        {
            health = health + 2;
            Debug.Log("Healthpackage achieved");
            Destroy(collision.gameObject);
        }



    }

    void DisplayHealth()
    {
        healthText.text = "Health: " + health.ToString();

    }

    void OnTriggerEnter(Collider other)
    {
        player.transform.position = respawnPoint.transform.position;
    }
}

    /*void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Wird aufgerufen!");
        }
    }*/

