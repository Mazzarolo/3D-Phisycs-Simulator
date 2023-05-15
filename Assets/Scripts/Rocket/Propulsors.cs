using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propulsors : MonoBehaviour
{
    [SerializeField] Rigidbody body;
    float force;

    void Start()
    {
        force = 15000.0f;
    }

    void Update()
    {
        Transform tr;
        Vector3 vec;

        if (Input.GetKey(KeyCode.Alpha1))
        {
            tr = transform.GetChild(0).GetComponent<Transform>();
            vec = tr.up.normalized;
            body.AddForce(force * vec);
        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            tr = transform.GetChild(1).GetComponent<Transform>();
            vec = tr.up.normalized;
            body.AddForce(force * vec);
        }

        if (Input.GetKey(KeyCode.Alpha3))
        {
            tr = transform.GetChild(2).GetComponent<Transform>();
            vec = tr.up.normalized;
            body.AddForce(force * vec);
        }

        if (Input.GetKey(KeyCode.Alpha4))
        {
            tr = transform.GetChild(3).GetComponent<Transform>();
            vec = tr.up.normalized;
            body.AddForce(force * vec);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            tr = transform.GetChild(0).GetComponent<Transform>();
            vec = tr.up.normalized;
            body.AddForce(force * vec);
            tr = transform.GetChild(1).GetComponent<Transform>();
            vec = tr.up.normalized;
            body.AddForce(force * vec);
            tr = transform.GetChild(2).GetComponent<Transform>();
            vec = tr.up.normalized;
            body.AddForce(force * vec);
            tr = transform.GetChild(3).GetComponent<Transform>();
            vec = tr.up.normalized;
            body.AddForce(force * vec);
        }
    }
}
