using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.gameObject.tag = "Mirror";
    }
}
