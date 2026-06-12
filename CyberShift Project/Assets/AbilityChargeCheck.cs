using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class AbilityChargeCheck : MonoBehaviour
{
    public AudioClip collectSound;

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.CompareTag("Player"))
        {
            Variables.Object(hitInfo.gameObject).Set("chargeAbility", true);

            if (collectSound != null)
            {
                AudioSource.PlayClipAtPoint(collectSound, Camera.main.transform.position);
            }

            Debug.Log("Charge Shot Active");

            Destroy(gameObject);
        }
    }
}
