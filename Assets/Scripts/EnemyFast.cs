using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyFast : Enemy
{
    [SerializeField] private GameObject player;

    public bool isFast;
    private float speedBackUp;

    float distance;
    float posX;
    float posZ;

    private void Awake()
    {
        player = GameObject.FindWithTag("Player");
        
        isFast = false;
        speedBackUp = speed;
    }

    public override void AttackPlayer()
    {
        distance = Vector3.Distance(playerPos, transform.position);

        if (distance < 10 && isFast == false)
        {
            isFast = true;
            Debug.Log("Distance lower than 10");
            StartCoroutine(SpeedUp());
        }
        

        playerPos = new Vector3(player.transform.position.x, 0, player.transform.position.z);
        enemyRb.velocity = (player.transform.position - transform.position).normalized * speed;
    }

    IEnumerator SpeedUp()
    {
        speed *= 2f;
        yield return new WaitForSeconds(0.8f);
        speed = speedBackUp;
        StartCoroutine(SpeedUpColdown());  
    }
    IEnumerator SpeedUpColdown()
    {
        yield return new WaitForSeconds(4f);
        isFast = false;
    }

}
