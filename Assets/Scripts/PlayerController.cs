using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField] float speed;
    [SerializeField] float horizontalImput;
    [SerializeField] float verticalImput;
    [SerializeField] float smooth = 4.0f;



    float zValue;
    float xValue;

    

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        zValue = 1;
    }

    private void Update()
    {
        horizontalImput = Input.GetAxisRaw("Horizontal");
        verticalImput = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate()
    {
        Rotate();

        rb.velocity = new Vector3(speed * horizontalImput, 0, speed * verticalImput);
    }

    private void Attack() 
    {
        
    }


    private void Rotate() 
    {
        

        if (horizontalImput == 1)
        {
            xValue = 1;
        }
        else if (horizontalImput == -1)
        {
            xValue = -1;
        }
        else
        {
            xValue = 0;
        }

        if (verticalImput == 1)
        {
            zValue = 1;
        }
        else if (verticalImput == -1)
        {
            zValue = -1;
        }
        else
        {
            zValue = 0;
        }

        if (xValue != 0)
        {
            Quaternion xRotate = Quaternion.Euler(0, 90 * xValue, 0);

            transform.rotation = Quaternion.Slerp(transform.rotation, xRotate, Time.deltaTime * smooth);
        }
        else if (zValue != 0) 
        {
            Quaternion zRotate;
            if (zValue == 1)
            {
                 zRotate = Quaternion.Euler(0, 0, 0);
            }
            else
            {
                 zRotate = Quaternion.Euler(0, 180, 0);
            }
            transform.rotation = Quaternion.Slerp(transform.rotation, zRotate, Time.deltaTime * smooth);
        }

    }
}
