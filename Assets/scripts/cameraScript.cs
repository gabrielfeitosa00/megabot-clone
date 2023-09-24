using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pc;
    public float x_offset = 5;
    public float y_offset = 3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3(pc.transform.position.x + x_offset, pc.transform.position.y + y_offset, -10);
        transform.position = pos;
    }
}
