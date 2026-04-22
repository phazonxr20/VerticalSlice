using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundScroll : MonoBehaviour
{
    // Start is called before the first frame update
    public float scrollEffectMultiplier;

    private Transform mainCamera;
    private Vector3 startPosition;
    void Start()
    {
        mainCamera = Camera.main.transform;
        startPosition = transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float distance = mainCamera.position.x * scrollEffectMultiplier;
        transform.position = new Vector3(startPosition.x + distance, transform.position.y, transform.position.z);
    }
}
