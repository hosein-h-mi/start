using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveingPlayer : MonoBehaviour
{
    public float speed;
    public float jump;
    private Rigidbody2D rigid;
    public Transform GroundCheck;
    public float GroundChekRadius;
    public LayerMask WhatIsGrounded;
    private bool Grounded;
    private bool DoubleJamping;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        Grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundChekRadius, WhatIsGrounded);
    }
    // Update is called once per frame
    void Update()
    {
        if (Grounded )
            DoubleJamping = false;
        
        if (Input.GetKeyDown(KeyCode.Space)&&Grounded )
        {
            rigid.velocity = new Vector2(0, jump);
        }
        if (Input.GetKeyDown(KeyCode.Space) &&! DoubleJamping &&! Grounded )
        {
            rigid.velocity = new Vector2(0, jump);
            DoubleJamping =true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigid.velocity = new Vector2(speed, 0);
        }
        if (Input.GetKey(KeyCode.A )) 
        {
            rigid.velocity = new Vector2(-speed,0);
        }

    }
}
