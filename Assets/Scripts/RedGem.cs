using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedGem : MonoBehaviour
{
    private bool hasTrigger;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("PlayerFire") && !hasTrigger)
        {
            hasTrigger = true;
            Destroy(gameObject);
        }
    }
}
