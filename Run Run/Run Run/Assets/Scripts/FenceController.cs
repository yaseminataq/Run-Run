using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceController : MonoBehaviour
{
     
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Fence")  
        {
            Destroy(collision.gameObject);
        }
    }
}
