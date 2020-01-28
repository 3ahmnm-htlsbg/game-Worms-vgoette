using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
    public int x;
    public string text;
    public float finish;

    // Start is called before the first frame update
    void Start()
    {
        /*
        if(x>0)
        {
            Debug.Log("x ist größer als 0");
            
        }
        else
        {
            Debug.Log("x ist kleiner als 0");
        }




        if (text == "HEWO")
        {
            Debug.Log("it be hewo");
        }
        else
        {
            Debug.Log("pls helo");
        }
        */

        if (finish > 10)
        {
            Debug.Log("number is bigger than 10");
        }

        else
        {
            Debug.Log("number is smaller than 10");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
