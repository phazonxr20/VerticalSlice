using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeFlash : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color chargeColor = Color.cyan;
    public float flashSpeed = 0.05f;

    private Color originalColor;
    private Coroutine flashCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        {
        if (spriteRenderer == null)
        {
            spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        }
        originalColor = spriteRenderer.color;
    }
    }

    public void chargeFlashStart()
    {
        if (flashCoroutine == null)
        {
            flashCoroutine = StartCoroutine(chargeCorutine());
        }
    }

    public void chargeFlashStop()
    {
        if (flashCoroutine != null)
        {
            StopCoroutine(flashCoroutine);
            flashCoroutine = null;
        }
        
        spriteRenderer.color = originalColor; 
    }

    IEnumerator chargeCorutine()
    {
        while (true)
        {
            spriteRenderer.color = chargeColor;
            yield return new WaitForSeconds(flashSpeed);
            
            spriteRenderer.color = originalColor;
            yield return new WaitForSeconds(flashSpeed);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
