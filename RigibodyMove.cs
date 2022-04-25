using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigibodyMove : PlayerMove
{
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + movement * speed * Time.fixedDeltaTime);
    }
}
