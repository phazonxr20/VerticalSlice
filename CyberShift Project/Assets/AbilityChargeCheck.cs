using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class AbilityChargeCheck : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.CompareTag("Player"))
        {
            Variables.Object(hitInfo.gameObject).Set("chargeAbility", true);

            Debug.Log("Charge Shot Active");

            Destroy(gameObject);
        }
    }
}
