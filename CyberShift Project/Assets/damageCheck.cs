using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageCheck : MonoBehaviour
{
    public int maxHealth = 3;
    private int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
            deleteEntity();
        }
    }

    void deleteEntity()
    {
        Destroy(gameObject);
    }

}
