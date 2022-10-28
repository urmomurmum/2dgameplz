using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabController : MonoBehaviour
{
    public Transform grabPoint;
    public Transform rayPoint;
    public float rayDistance;

    private GameObject grabbedObject;
    private int layerIndex;


    public Vector2 movement;

    private void Start()
    {
        layerIndex = LayerMask.NameToLayer("Objects");
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        

        RaycastHit2D hitInfo = Physics2D.Raycast(rayPoint.position, movement, rayDistance);

        if (hitInfo.collider != null && hitInfo.collider.gameObject.layer == layerIndex)
        {
            
            if (Input.GetKeyDown(KeyCode.G) && grabbedObject == null)
            {
                grabbedObject = hitInfo.collider.gameObject;
                grabbedObject.GetComponent<Rigidbody2D>().isKinematic = true;
                grabbedObject.transform.position = grabPoint.position;
                grabbedObject.transform.SetParent(transform);
            }
            else if (Input.GetKeyDown(KeyCode.G))
            {
                grabbedObject.GetComponent<Rigidbody2D>().isKinematic = false;
                grabbedObject.transform.SetParent(null);
                grabbedObject = null;
            }
        }

        if (movement.x > 0 && grabbedObject == null)
        {
            grabPoint.transform.position = grabPoint.transform.parent.TransformPoint(1.829f, -0.229f, 0);
            rayPoint.transform.position = rayPoint.transform.parent.TransformPoint(0.848f, -0.241f, 0);
        }
        if (movement.x < 0 && grabbedObject == null)
        {
            grabPoint.transform.position = grabPoint.transform.parent.TransformPoint(-1.829f, -0.229f, 0);
            rayPoint.transform.position = rayPoint.transform.parent.TransformPoint(-0.848f, -0.241f, 0);
        }

        Debug.DrawRay(rayPoint.position, movement * rayDistance);
    }
}
