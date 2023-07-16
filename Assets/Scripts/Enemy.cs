using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Rigidbody enemyRb;
    [SerializeField] private GameObject player;

    Vector3 playerPos;
    private float speed = 8f;

    private void FixedUpdate()
    {
        AttackPlayer();
    }


    private void AttackPlayer() 
    {
        playerPos = new Vector3(player.transform.position.x, 0, player.transform.position.z);
        enemyRb.velocity = (player.transform.position - transform.position).normalized * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Weapon" ) 
        {
            Destroy(gameObject);
        }
    }
}
