using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boltScript : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb2d;
    public float speed = 15f;
    
    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    public void FireInDirection(float direction)
    {
        rb2d.velocity = new Vector2(speed * direction, 0);

        if (direction < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
