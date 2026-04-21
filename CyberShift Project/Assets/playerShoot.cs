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
                GameObject bolt = Instantiate(boltPrefab);
                bolt.transform.position = new Vector3(transform.position.x + .4f, transform.position.y + .2f, -1);
            }
            else
            {
                Debug.LogWarning("Bolt Prefab is not assigned in the Inspector!");
            }
        }
    }
}
