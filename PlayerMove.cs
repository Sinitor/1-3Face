using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] protected float speed = 5;
    [SerializeField] protected Vector3 movement;
    protected void Update()
    {
        movement = transform.right * Input.GetAxis("Horizontal") + Input.GetAxis("Vertical") * transform.forward;
    }
}
