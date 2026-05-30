using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boltScript : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb2d;
    public float speed = 15f;
    public float bulletLifetime = 2f;
    public int damageValue = 1;
    public string layerName = "Enemy";
    public bool startLeftSide = false;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Destroy(gameObject, bulletLifetime);
    }

    public void FireInDirection(float direction)
    {
        rb2d.velocity = new Vector2(speed * direction, 0);
        Vector3 currentScale = transform.localScale;

        float visualDirection = direction;
        if (startLeftSide)
        {

            visualDirection = -direction; 
        }

        if (visualDirection < 0)
        {
            currentScale.x = -Mathf.Abs(currentScale.x);
        }
        else
        {
            currentScale.x = Mathf.Abs(currentScale.x);
        }
        transform.localScale = currentScale;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.gameObject.layer == LayerMask.NameToLayer(layerName))
        {
            damageCheck targetdamageCheck = hitInfo.GetComponent<damageCheck>();
            if (targetdamageCheck != null)
            {
                targetdamageCheck.TakeDamage(damageValue);
            }

            Destroy(gameObject);
            Debug.Log("Hit enemy");
        }
        else if (hitInfo.gameObject.layer == LayerMask.NameToLayer("Default"))
        {
            Destroy(gameObject);
        }
    }
}
