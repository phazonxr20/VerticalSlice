using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBrains : MonoBehaviour
{
    public enum BossState { Idle, Jumping, Shooting }
    public BossState currentState;
    public Rigidbody2D rb2d;
    public GameObject bossShotPrefab;
    public Transform ShotSpawnPointB;
    public float jumpForce = 15f;
    public float jumpForwardSpeed = -5f;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        StartCoroutine(BossPatternLoop());
    }

    IEnumerator BossPatternLoop()
    {
        while (true) 
        {
            currentState = BossState.Idle;
            yield return new WaitForSeconds(2f);

            currentState = BossState.Jumping;
            rb2d.AddForce(new Vector2(jumpForwardSpeed, jumpForce), ForceMode2D.Impulse);
            yield return new WaitForSeconds(1.5f);

            currentState = BossState.Shooting;
            Shoot();
            yield return new WaitForSeconds(0.5f); 
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bossShotPrefab, ShotSpawnPointB.position, Quaternion.identity);
        
        boltScript bulletLogic = bullet.GetComponent<boltScript>();
        
        if (bulletLogic != null)
        {
            bulletLogic.FireInDirection(-1f);
        }
        else
        {
            Debug.LogWarning("No bolt to fire");
        }
    }
}
