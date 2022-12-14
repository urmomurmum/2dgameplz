using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animatorb;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        //Input

        movement.x = Input.GetAxisRaw("Horizontal2");
        movement.y = Input.GetAxisRaw("Vertical2");

        animatorb.SetFloat("Horizontal", movement.x);
        animatorb.SetFloat("Speed", movement.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        //Movement

        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
