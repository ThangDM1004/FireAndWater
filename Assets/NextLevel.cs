using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    [SerializeField] private GameObject Player1Door;
    [SerializeField] private GameObject Player2Door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void IsCollision()
    {
        if(Player1Door.gameObject.CompareTag("PlayerWater") && Player2Door.gameObject.CompareTag("PlayerFire"))
        {
            Debug.Log("Next level");
        }
    }
}
