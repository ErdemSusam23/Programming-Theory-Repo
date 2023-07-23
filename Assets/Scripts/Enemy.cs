using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] public Rigidbody enemyRb;
    [SerializeField] public GameObject player;
    private PlayerController playerController;

    public Vector3 playerPos { get; protected set;}
    public float speed = 6f;

    private void Awake()
    {
        playerController = FindAnyObjectByType<PlayerController>();
        player = GameObject.FindWithTag("Player");
    }
    private void FixedUpdate()
    {
        AttackPlayer();
    }

    public virtual void AttackPlayer() 
    {
        playerPos = new Vector3(player.transform.position.x, 0, player.transform.position.z);
        enemyRb.velocity = (player.transform.position - transform.position).normalized * speed;
    }

    public virtual void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Weapon")
        {
            Destroy(gameObject);
            playerController.score += 10;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
        }
    }
}
