using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Rigidbody enemyRb;
    [SerializeField] private GameObject player;

    Vector3 playerPos;
    private float speed = 6f;

    private void Awake()
    {
        player = GameObject.FindWithTag("Player");
    }
    private void FixedUpdate()
    {
        AttackPlayer();
    }

    private void AttackPlayer() 
    {
        playerPos = new Vector3(player.transform.position.x, 0, player.transform.position.z);
        enemyRb.velocity = (player.transform.position - transform.position).normalized * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Weapon")
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("Player Collision");
        }
    }
}
