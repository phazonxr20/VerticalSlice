using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageCheck : MonoBehaviour
{
    public int maxHealth = 3;
    private int currentHealth;
    public SpriteRenderer spriteRenderer;
    public Color flashColor = Color.red;
    public float flashDuration = 0.15f;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        if (spriteRenderer == null)
        {

            spriteRenderer = GetComponentInChildren<SpriteRenderer>(); 
        }
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        if (spriteRenderer != null)
        {
            StartCoroutine(FlashRoutine());
        }
        if (currentHealth <= 0)
        {
            deleteEntity();
        }
    }

    void deleteEntity()
    {
        Destroy(gameObject);
    }

    IEnumerator FlashRoutine()
    {
        Color originalColor = spriteRenderer.color;
        spriteRenderer.color = flashColor;
        yield return new WaitForSeconds(flashDuration);
        
        spriteRenderer.color = originalColor;
    }
}
