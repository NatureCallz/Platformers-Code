using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuchGracza : MonoBehaviour
{

    public float moveSpeed;
    public float jumpHeight;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask WhatIsGround;
    private bool grouned;
    public bool doubleJump;

    private Animator anim;

    // Use this for initialization
    void Start(){
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        grouned = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, WhatIsGround);
    }

    // Update is called once per frame
    void Update()
    {

        if (grouned)
            doubleJump = false;
        anim.SetBool("Grounded",grouned);

            if (Input.GetKeyDown(KeyCode.Space)&& grouned)
        {
            Jump();
        }

        if (Input.GetKeyDown(KeyCode.Space) && !grouned && !doubleJump)
        {
            Jump();
            doubleJump = true;
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////
            if (Input.GetKey(KeyCode.RightArrow))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            }
            anim.SetFloat("Speed",Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
        if (GetComponent<Rigidbody2D>().velocity.x > 0)
            transform.localScale = new Vector3(1f, 1f, 1f);
        else if (GetComponent<Rigidbody2D>().velocity.x < 0)
        transform.localScale = new Vector3(-1f, 1f, 1f);
    }

    void Jump() {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpHeight);

        }

    
 
}
