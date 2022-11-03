using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public Transform player;
    readonly float maxPosition = 1;

    void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, -10);
        transform.position = new Vector3(player.position.x, transform.position.y, -10);
        //if (player.transform.position.y < maxPosition)
        //{
        //    transform.position = new Vector3(player.position.x, player.position.y, -10);
        //}
        //else if (player.transform.position.y > maxPosition)
        //{
        //    transform.position = new Vector3(player.position.x, transform.position.y, -10);
        //}
    }
}
