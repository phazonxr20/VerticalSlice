using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundScroll : MonoBehaviour
{
    // Start is called before the first frame update
    public float scrollEffectMultiplier;

    private Transform mainCamera;
    private float startPosition;
    private float spriteSize;
    void Start()
    {
        mainCamera = Camera.main.transform;
        startPosition = transform.position.x;
        spriteSize = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float backgroundCameraPosition = mainCamera.position.x * (1 - scrollEffectMultiplier);
        float backgroundDistance = mainCamera.position.x * scrollEffectMultiplier;
        transform.position = new Vector3(startPosition + backgroundDistance, transform.position.y, transform.position.z);
        if (backgroundCameraPosition > startPosition + spriteSize)
        {
            startPosition += spriteSize;
        }
        else if (backgroundCameraPosition < startPosition - spriteSize)
        {
            startPosition -= spriteSize;
        }
    }
}
