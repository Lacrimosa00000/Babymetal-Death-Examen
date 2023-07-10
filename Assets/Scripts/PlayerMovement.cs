using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D rb;
    public Animator anim;
    public SpriteRenderer spRen;

    public float playerSpeed = 5f;
    public float jumpForce = 5f;

    private void Update()
    {

        float h = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;

        transform.Translate(h, 0, 0);

        if (h < 0f)
        {

            SpriteRenderer.flipX = true;

        }
        else if (h > 0f) 
        {

            SpriteRenderer.flipX = false;

        }

        //jump

        if (Input.GetKeyDown(KeyCode.W))
        {

            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

        }

        //run animation

        if (h != 0)
        {

            anim.SetFloat("speed", 1);

        }
        else
        {

            anim.SetFloat("speed", 0);

        }

    }

}
