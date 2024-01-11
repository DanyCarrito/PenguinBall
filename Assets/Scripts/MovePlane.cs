using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlane : MonoBehaviour
{
    private float angleRot = 0f;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            angleRot += 0.5f;
            Vector3 rA = transform.eulerAngles;
            transform.eulerAngles = new Vector3(rA.x, rA.y, angleRot);
        }

        if (Input.GetKey(KeyCode.D))
        {
            angleRot -= 0.5f;
            Vector3 rA = transform.eulerAngles;
            transform.eulerAngles = new Vector3(rA.x, rA.y, angleRot);
        }

        if (Input.GetKey(KeyCode.W))
        {
            angleRot += 0.5f;
            Vector3 rA = transform.eulerAngles;
            transform.eulerAngles = new Vector3(angleRot, rA.y, rA.z);
        }

        if (Input.GetKey(KeyCode.S))
        {
            angleRot -= 0.5f;
            Vector3 rA = transform.eulerAngles;
            transform.eulerAngles = new Vector3(angleRot, rA.y, rA.z);
        }
    }
}
