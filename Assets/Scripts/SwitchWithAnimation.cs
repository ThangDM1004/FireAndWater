using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWithAnimation : MonoBehaviour
{
    private CapsuleCollider2D coll;
    [SerializeField] private LayerMask jumpableGround;
    [SerializeField] private GameObject BtnOther;
    bool isPlayer = false;
    [SerializeField] private GameObject door;
    void Start()
    {
        coll = GetComponent<CapsuleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsGounded())
        {
            BtnOther.GetComponent<SwitchWithAnimation>().enabled = false;
            isPlayer = true;
            door.GetComponent<Animator>().SetBool("isSwitch", true);
        }
        else
        {
            BtnOther.GetComponent<SwitchWithAnimation>().enabled = true;
            isPlayer = false;
            door.GetComponent<Animator>().SetBool("isSwitch", false);
        }
    }
    private bool IsGounded()
    {
        return Physics2D.CapsuleCast(coll.bounds.center, coll.bounds.size, CapsuleDirection2D.Horizontal, 0.21f, Vector2.up, 0.05429767f, jumpableGround);
    }
}
