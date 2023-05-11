using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phisycs : MonoBehaviour
{
    
    void Update ()
    {
        Debug.Log(GetComponent<Rigidbody>().velocity);
    }

    void OnCollisionEnter ()
    {
        Vector3 opposite = -GetComponent<Rigidbody>().velocity;
        GetComponent<Rigidbody>().AddForce(opposite * 2);
        Debug.Log(opposite);
    }
}
