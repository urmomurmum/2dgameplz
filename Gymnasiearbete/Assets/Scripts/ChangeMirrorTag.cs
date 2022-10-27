using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMirrorTag : MonoBehaviour
{
    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        float speed = rb.velocity.magnitude;

        GameObject child = gameObject.transform.GetChild(0).gameObject;

        if (speed == 0)
        {
            child.tag = "Mirror";
        }
        else
        {
            child.tag = "Untagged";

        }
    }
}
