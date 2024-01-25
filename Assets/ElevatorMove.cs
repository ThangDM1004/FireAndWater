using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorMove : MonoBehaviour
{
    public Transform posA, posB;
    int speed = 2;
    Vector2 targetPos;
    void Start()
    {
        targetPos = posB.position;
    }

    void Update()
    {
        if(Vector2.Distance(transform.position, posA.position) < .1f) targetPos = posB.position;

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }
}
