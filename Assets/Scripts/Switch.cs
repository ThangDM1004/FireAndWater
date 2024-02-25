using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    private CapsuleCollider2D coll;
    public Transform posA, posB;
    Vector2 targetPos;
    [SerializeField] private LayerMask jumpableGround;
    [SerializeField] private GameObject evelator;
    [SerializeField] private GameObject BtnOther;
    int speed = 1;
    bool isPlayer = false;
    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<CapsuleCollider2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsGounded())
        {
            BtnOther.GetComponent<Switch>().enabled = false;
            isPlayer = true;
        }
        else
        {
            BtnOther.GetComponent<Switch>().enabled = true;
            isPlayer = false;
        }
        if (isPlayer)
        {
            targetPos = posB.position;
        }
        else
        {
           targetPos = posA.position;
        }
        evelator.transform.position = Vector2.MoveTowards(evelator.transform.position, targetPos, speed * Time.deltaTime);
    }
    private bool IsGounded()
    {
        return Physics2D.CapsuleCast(coll.bounds.center, coll.bounds.size, CapsuleDirection2D.Horizontal, 0.21f, Vector2.up, 0.05429767f, jumpableGround);
    }
}
