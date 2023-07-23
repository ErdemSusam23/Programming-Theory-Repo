using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyFast : Enemy
{
    private PlayerController pController;

    public bool isFast;
    private float speedBackUp;

    float distance;
    float posX;
    float posZ;

    private void Awake()
    {
        pController = FindAnyObjectByType<PlayerController>();
        player = GameObject.FindWithTag("Player");
        
        isFast = false;
        speedBackUp = speed;
    }

    public override void AttackPlayer()
    {
        distance = Vector3.Distance(playerPos, transform.position);

        if (distance < 8 && isFast == false)
        {
            DashToPlayer();
        }
        playerPos = new Vector3(player.transform.position.x, 0, player.transform.position.z);
        enemyRb.velocity = (player.transform.position - transform.position).normalized * speed;
    }

    public override void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Weapon")
        {
            Destroy(gameObject);
            pController.score += 15;
        }
    }

    private void DashToPlayer() 
    {
        isFast = true;
        StartCoroutine(SpeedUp());  
    }

    IEnumerator SpeedUp()
    {
        speed *= 2.5f;
        yield return new WaitForSeconds(0.5f);
        speed = speedBackUp;
        StartCoroutine(SpeedUpColdown());  
    }
    IEnumerator SpeedUpColdown()
    {
        yield return new WaitForSeconds(4f);
        isFast = false;
    }

}
