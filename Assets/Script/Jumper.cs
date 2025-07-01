using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{


    [SerializeField]
    private Rigidbody myRigidbody;
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.AddForce(0, 500, 0);
    }
    void Move()
    {
        
    }
}