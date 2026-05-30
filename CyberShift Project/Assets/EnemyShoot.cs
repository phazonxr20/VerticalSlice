using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject enemyShotPrefab;
    public Transform ShotSpawnPointE;
    public float shotTimer = 2f;
    public float shotRange = 10f;
    private Transform playerTarget;
    public bool startLeftSide = false;

    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            playerTarget = player.transform;
        }

        StartCoroutine(shootingCoroutine());
    }

    IEnumerator shootingCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(shotTimer);

            if (playerTarget != null && Vector2.Distance(transform.position, playerTarget.position) <= shotRange)
            {
                ShootAtPlayer();
            }
        }
    }

    void ShootAtPlayer()
    {
        GameObject bullet = Instantiate(enemyShotPrefab, ShotSpawnPointE.position, Quaternion.identity);
        boltScript bulletLogic = bullet.GetComponent<boltScript>();

        if (bulletLogic != null)
        {
            float direction = (playerTarget.position.x < transform.position.x) ? -1f : 1f;
            bulletLogic.FireInDirection(direction);
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (playerTarget != null && Vector2.Distance(transform.position, playerTarget.position) <= shotRange)
        {
            LookAtPlayer();
        }
    }

    void LookAtPlayer()
    {
        Vector3 currentScale = transform.localScale;
        // left
        if (playerTarget.position.x < transform.position.x)
        {
  
            currentScale.x = startLeftSide ? Mathf.Abs(currentScale.x) : -Mathf.Abs(currentScale.x);
        }
        // right
        else
        {
            currentScale.x = startLeftSide ? -Mathf.Abs(currentScale.x) : Mathf.Abs(currentScale.x);
        }
        transform.localScale = currentScale;
    }
}
