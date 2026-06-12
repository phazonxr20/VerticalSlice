using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class damageCheck : MonoBehaviour
{
    public int maxHealth = 3;
    private int currentHealth;
    public SpriteRenderer spriteRenderer;
    public Color flashColor = Color.red;
    public float flashDuration = 0.15f;
    public AudioSource audioSource;
    public AudioClip hurtSound;
    public Image healthBarFill;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthBar();
        if (spriteRenderer == null)
        {

            spriteRenderer = GetComponentInChildren<SpriteRenderer>(); 
        }
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        UpdateHealthBar();UpdateHealthBar();

        if (audioSource != null && hurtSound != null)
        {
            audioSource.PlayOneShot(hurtSound);
        }

        if (spriteRenderer != null)
        {
            StartCoroutine(FlashCoroutine());
        }

        if (gameObject.CompareTag("Player"))
        {
            DamageGlitch glitchEffect = FindObjectOfType<DamageGlitch>();
            if (glitchEffect != null)
            {
                glitchEffect.TriggerGlitch();
            }
        }

        if (currentHealth <= 0)
        {
            deleteEntity();
        }
    }

    void UpdateHealthBar()
    {
        if (healthBarFill != null)
        {
            healthBarFill.fillAmount = (float)currentHealth / (float)maxHealth;
        }
    }

    void deleteEntity()
    {
        if (gameObject.CompareTag("Player"))
        {
            GameOverScript go = FindObjectOfType<GameOverScript>();
            if (go != null)
            {
                go.TriggerGameOver();
            }
        }

        Destroy(gameObject);
    }

    IEnumerator FlashCoroutine()
    {
        Color originalColor = spriteRenderer.color;
        spriteRenderer.color = flashColor;
        yield return new WaitForSeconds(flashDuration);
        
        spriteRenderer.color = originalColor;
    }
}
