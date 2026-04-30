using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject boltPrefab;
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (boltPrefab != null) 
            {
                float direction = Mathf.Sign(transform.localScale.x);
                Vector3 spawnPosition = new Vector3(transform.position.x + (0.7f * direction), transform.position.y + 0.06f, -1);

                GameObject bolt = Instantiate(boltPrefab, spawnPosition, Quaternion.identity);

                boltScript shootLogic = bolt.GetComponent<boltScript>();
                if (shootLogic != null)
                {
                    shootLogic.FireInDirection(direction);
                }
            }
            else
            {
                Debug.LogWarning("No bolt to fire");
            }
        }
    }
}
