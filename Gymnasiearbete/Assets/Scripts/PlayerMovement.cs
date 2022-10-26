using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody rb;

    Vector3 movement;

    // Update is called once per frame
    void Update()
    {
        Physics.IgnoreLayerCollision(8, 9);
        //Input

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        
       
    }

    private void FixedUpdate()
    {
        //Movement

        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        
    }
}
