using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBall : MonoBehaviour
{

    public Rigidbody myRB;

    public float speed = 5f;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        //myRB.AddForce(Vector3.forward*speed);
        myRB.AddForce(new Vector3(hor*speed, 0f, ver*speed));

    }
}
