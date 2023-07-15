using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject player;

    private void LateUpdate()
    {
        gameObject.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 57, player.transform.position.z - 50);
    }
}
