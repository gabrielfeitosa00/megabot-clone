using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pcScript : MonoBehaviour
{
    private Rigidbody2D rbd;
    private Animator anim;
    private bool right = true;
    public float vel;
    public float jumpForce;
    public LayerMask ground;
    public GameObject foot;
    // Start is called before the first frame update
    void Start()
    {
        vel = 7;
        jumpForce = 7;
        rbd = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        rbd.velocity = new Vector2(x * vel, rbd.velocity.y);
        RaycastHit2D groundHitRay = Physics2D.Raycast(foot.transform.position, -foot.transform.up, .5f, ground);
        bool groundHit = groundHitRay.collider != null ? true : false;
        MovePC(x);
        JumpPC(groundHit);



    }

    private void MovePC(float xAxis)
    {
        if (xAxis == 0)
        {
            anim.SetBool("isWalking", false);
        }
        else
        {
            anim.SetBool("isWalking", true);
            if (right && xAxis < 0 || !right && xAxis > 0)
            {
                transform.Rotate(0, 180, 0);
                right = !right;
            }
        }
    }

    private void JumpPC(bool groundHit)
    {
        if (Input.GetKeyDown(KeyCode.Space) && groundHit)
        {

            rbd.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            anim.SetBool("isJumping", true);

        }
        else if (groundHit && rbd.velocity.y < -.1f)
        {
            anim.SetBool("isJumping", false);
            anim.SetBool("isFalling", true);
        }
        else if (groundHit && rbd.velocity.y == 0f)
        {

            anim.SetBool("isFalling", false);
            anim.SetBool("isJumping", false);

        }
    }
}
