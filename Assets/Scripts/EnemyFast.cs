using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyFast : Enemy
{
    public float speedUpSpeed;

    int distance;
    float posX;
    float posZ;

    private void Awake()
    {
        speedUpSpeed = 18f;
    }
    private void FixedUpdate()
    {
        AttackPlayer();
    }

    public override void AttackPlayer()
    {
        posX = transform.position.x;
        posZ = transform.position.z;
        distance = Mathf.FloorToInt(Mathf.Abs(Mathf.Sqrt((playerPos.x * playerPos.x + posX * posX) + (playerPos.z * playerPos.z + posZ * posZ))));

        if (distance < 10)
        {
            StartCoroutine(SpeedUp());
        }

        playerPos = new Vector3(player.transform.position.x, 0, player.transform.position.z);
        enemyRb.velocity = (player.transform.position - transform.position).normalized * speed;
    }

    IEnumerator SpeedUp()
    {
        enemyRb.velocity = (player.transform.position - transform.position).normalized * speedUpSpeed;
        yield return new WaitForSeconds(0.5f);
    }
}
