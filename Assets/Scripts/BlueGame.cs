using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueGame : MonoBehaviour
{
    private bool hasTrigger;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerWater") && !hasTrigger)
        {
            hasTrigger = true;
            Destroy(gameObject);
            
        }
    }
}
