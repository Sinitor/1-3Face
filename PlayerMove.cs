using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] protected float speed = 5;
    [SerializeField] protected Vector3 movement;
    [SerializeField] Animator anim;
    [SerializeField] GameObject sword;
    protected void Update()
    {
        movement = transform.right * Input.GetAxis("Horizontal") + Input.GetAxis("Vertical") * transform.forward;
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            anim.SetBool("Walk",true);
            anim.SetBool("Hit", false);
            anim.SetBool("Dance", false);
            anim.SetBool("DanceTwo", false);
            sword.gameObject.SetActive(true);
        }
        else
        {
            anim.SetBool("Walk", false);
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift))
        {
            anim.SetBool("Run", true);
            anim.SetBool("Hit", false);
            sword.gameObject.SetActive(false);
            anim.SetBool("Dance", false);
            anim.SetBool("DanceTwo", false);
            speed = 8;
        }
        else
        {
            anim.SetBool("Run", false);
            speed = 5;
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            sword.gameObject.SetActive(true);
            anim.SetBool("Hit",true);
            anim.SetBool("Dance", false);
            anim.SetBool("DanceTwo", false);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            anim.SetBool("Dance", true);
            sword.gameObject.SetActive(false);
        } 
        if (Input.GetKeyDown(KeyCode.B))
        {
            anim.SetBool("DanceTwo", true);
            sword.gameObject.SetActive(false);
        }
    }
}
