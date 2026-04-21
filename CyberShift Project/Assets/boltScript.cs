using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boltScript : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(3, 0);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
