using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerContactDamage : MonoBehaviour
{
   public int damageValue = 1;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            damageCheck playerdamageCheck = collision.gameObject.GetComponent<damageCheck>();
            if (playerdamageCheck != null)
            {
                playerdamageCheck.TakeDamage(damageValue);
                Debug.Log("Damage taken");
            }
        }
    }
}
