using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Transform myTransform;
    [SerializeField] float speed;

    void Start()
    {
        myTransform = GetComponent<Transform>();
    }
    
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            myTransform.position += new Vector3(0, 0.01f, 0)* speed;
        }
        if (Input.GetKey("a"))
        {
            myTransform.position += new Vector3(-0.01f, 0, 0)* speed;
        }
        if (Input.GetKey("s"))
        {
            myTransform.position += new Vector3(0, -0.01f, 0)* speed;
        }
        if (Input.GetKey("d"))
        {
            myTransform.position += new Vector3(0.01f, 0, 0)* speed;
        }
    }
}
