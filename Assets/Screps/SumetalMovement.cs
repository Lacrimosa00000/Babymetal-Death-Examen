using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumetalMovement : MonoBehaviour
{
    public float Speed;
    public float JumpForce;

    private Rigidbody2D Rigidbody2D;
    private float Horizontal;
    private Animator Animator;
    //private bool Grounded;

    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
    }

    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");

        if (Horizontal < 0.0f) transform.localScale = new Vector3(-10.0f, 10.0f, 10.0f);
        else if (Horizontal > 0.0f) transform.localScale = new Vector3(10.0f, 10.0f, 10.0f);

        Animator.SetBool("Runing", Horizontal != 0.0f);

        //Debug.DrawRay(transform.position, Vector3.down * 0.1f, Color.red);
        //if (Physics2D.Raycast(transform.position, Vector3.down, 0.1f))
        //{ Grounded = true;}
        //else Grounded = false;

        if (Input.GetKeyDown(KeyCode.W)) //&& Grou)
        {
            Jump();
        }
            
    }

    private void Jump()
    {
        Rigidbody2D.AddForce(Vector2.up * JumpForce);
    }

    private void FixedUpdate()
    {
        Rigidbody2D.velocity = new Vector2(Horizontal, Rigidbody2D.velocity.y);
    }
}
