using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathbox : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        damageCheck damageCheckComponent = collision.GetComponent<damageCheck>();
        
        if (damageCheckComponent != null)
        {
            damageCheckComponent.TakeDamage(999);
        }
        else
        {
            Destroy(collision.gameObject);
        }
    }
}
