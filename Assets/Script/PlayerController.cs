using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float _speed = 0;

    Rigidbody _rd;

    // Start is called before the first frame update
    void Start()
    {
        _rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        float HorizontalKey = Input.GetAxis("Horizontal");
        float VerticalKey = Input.GetAxis("Vertical");
        float JumpKey = Input.GetAxis("Jump");


        if (HorizontalKey > 0)
        {
            _rd.velocity = new Vector3(HorizontalKey * _speed, _rd.velocity.y,_rd.velocity.z);
        }
        else if (HorizontalKey < 0)
        {
            _rd.velocity = new Vector3(HorizontalKey * _speed, _rd.velocity.y, _rd.velocity.z);
        }

        if (VerticalKey > 0)
        {
            _rd.velocity = new Vector3(_rd.velocity.x, _rd.velocity.y, VerticalKey * _speed);
        }
        else if(VerticalKey < 0)
        {
            _rd.velocity = new Vector3(_rd.velocity.x, _rd.velocity.y, VerticalKey * _speed);
        }
    }
        
}
