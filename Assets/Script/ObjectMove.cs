using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    ///[SerializeField] Vector3 _dir;

    ///[SerializeField] float _speed;
     Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();  
        Move();
    }

    public void Move()
    {
        rb.AddForce(new Vector3(0, 0,1500));
    }
}
