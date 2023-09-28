using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class metScript : MonoBehaviour
{
    // Start is called before the first frame update
 
    public float vel;
    public LayerMask ground;
    public GameObject colCheck;
    private float dir = -1;

    void Start()
    {
        

        vel = 2f;

  
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.TransformDirection(new Vector2(vel * Time.deltaTime*dir, 0)));
        RaycastHit2D wallHitRay = Physics2D.Raycast(colCheck.transform.position, dir*colCheck.transform.right, .5f, ground);
        if(wallHitRay.collider != null)
        {
            dir = dir * (-1);
            transform.Rotate(0, 180, 0);
        }
    }
}
