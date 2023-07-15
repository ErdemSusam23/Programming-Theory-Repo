using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField] float speed;
    [SerializeField] float horizontalImput;
    [SerializeField] float verticalImput;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        horizontalImput = Input.GetAxis("Horizontal");
        verticalImput = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(speed * horizontalImput, rb.velocity.y, speed * verticalImput);
    }
}
