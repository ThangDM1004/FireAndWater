using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorMove : MonoBehaviour
{
    public Transform posA, posB;
    int speed = 1;
    Vector2 targetPos;
    bool IsSwitch = false;
    [SerializeField] private GameObject evelator;
    private bool hasTrigger;
    private Animator animator;
    void Start()
    {
        targetPos = posB.position;
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (IsSwitch)
        {
            if (Vector2.Distance(evelator.transform.position, posA.position) < .1f) targetPos = posB.position;
            if (Vector2.Distance(evelator.transform.position, posB.position) < .1f) targetPos = posA.position;

            evelator.transform.position = Vector2.MoveTowards(evelator.transform.position, targetPos, speed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.CompareTag("PlayerWater") || collision.CompareTag("PlayerFire")) && !hasTrigger)
        {
            IsSwitch = !IsSwitch;
            animator.SetBool("isSwitch", IsSwitch);
        }
    }

}
