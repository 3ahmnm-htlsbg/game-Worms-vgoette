using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WormController_2 : MonoBehaviour
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

    void Update()
    {
        //transform Player

        if (Input.GetKeyDown(KeyCode.L))
        {
            rb.AddForce(move);
            rb.AddForce(jump);

        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            rb.AddForce(-move);
            rb.AddForce(jump);

        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            rb.AddForce(jump);
        }


        if (Input.GetKeyDown(KeyCode.K))
        {
            GameObject sphere = Instantiate(weapon, bulletPosition.position, Quaternion.identity);
            sphere.GetComponent<Rigidbody>().AddForce(bazooka.transform.up * shoot);
        }

        if (Input.GetKey(KeyCode.U))
        {
            bazooka.transform.Rotate(-5, 0, 0, Space.Self);
            Debug.Log("Button Input detected");
        }

        if (Input.GetKey(KeyCode.O))
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
}

    /*void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Wird aufgerufen!");
        }
    }*/

