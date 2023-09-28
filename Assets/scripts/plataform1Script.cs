using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataform1Script : MonoBehaviour
{
    private float count=0;
    public float deltaSpace=2f;
    public float radiusX = 3f;
    public float radiusY = 3f;
    private Vector2 posStart;
    // Start is called before the first frame update
    void Start()
    {
        posStart = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Sin(count) * radiusX;
        float y = Mathf.Cos(count) * radiusY;
        count += deltaSpace * Time.deltaTime;
        Vector2 posNew= new Vector2 (posStart.x + x, posStart.y + y);
        transform.position = posNew;
    }
}
