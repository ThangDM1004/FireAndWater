using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2Move : MonoBehaviour
{
    // Start is called before the first frame update
    Vector2 move;
    int speed = 5;
    int jump = 4;
    Rigidbody2D rb;
    SpriteRenderer sr;
    private CapsuleCollider2D coll;
    [SerializeField] private LayerMask jumpableGround;
    [SerializeField] private GameObject player;
    private Animator animator;
    public GemManager gm;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<CapsuleCollider2D>();
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        gm = GameObject.FindObjectOfType<GemManager>();
    }

    private void Update()
    {
        Vector2 move = Vector2.zero;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            move.x = -1f;
            sr.flipX = true;
            animator.SetBool("running", true);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            move.x = 1f;
            sr.flipX = false;
            animator.SetBool("running", true);
        }
        else
        {
            animator.SetBool("running", false);
        }
        if (Input.GetKey(KeyCode.UpArrow) && IsGounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jump);
        }
        rb.velocity = new Vector2(move.x * speed, rb.velocity.y);
    }

    private bool IsGounded()
    {
        return Physics2D.CapsuleCast(coll.bounds.center, coll.bounds.size, CapsuleDirection2D.Horizontal, 0.14f, Vector2.down, .06f, jumpableGround);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Water") || collision.gameObject.CompareTag("Poison"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else if (collision.gameObject.CompareTag("RedGem"))
        {
            Destroy(collision.gameObject);
            gm.gemCount++;
        }
        if (collision.gameObject.CompareTag("fireDoor"))
        {
            gm.doorFire = true;
        }
        else
        {
            gm.doorFire = false;
        }
    }
}
