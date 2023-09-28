using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class footScript : MonoBehaviour
{
   
    void OnCollisionEnter2D(Collision2D col)
    {    
        if (col.collider.tag == "player")
        {
           // transform.parent.GetComponent<Collider2D>().enabled = false;
            Debug.Log("Here");
            Destroy(transform.parent.gameObject);
        }
    }
}
