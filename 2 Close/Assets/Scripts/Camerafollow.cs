using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public BoxCollider2D mapBoundries;
    public Transform player;
    readonly float maxPositionY = 4.5f;
    float minPositionY = -11.3f;
    float minPositionX = -4.8f;
    float maxPositionX = 19.3f;
    void Update()
    {
        //transform.position = new Vector3(player.position.x, player.position.y, -10);
        //transform.position = new Vector3(player.position.x, transform.position.y, -10);

        

        //Boundries for Y
        ////Om inom boundries up down
        if (player.transform.position.y < maxPositionY && player.transform.position.y>minPositionY && player.transform.position.x < maxPositionX && player.transform.position.x > minPositionX)
        {
            transform.position = new Vector3(player.position.x, player.position.y, -10);
        }
        // If outside borders up left corner
        else if (player.transform.position.y > maxPositionY && player.transform.position.x < minPositionX)
        {
            transform.position = new Vector3(minPositionX, maxPositionY,-10);
        }
        // If outside borers up right corner
        else if (player.transform.position.y > maxPositionY && player.transform.position.x > maxPositionX)
        {
            transform.position = new Vector3(maxPositionX, maxPositionY, -10);
        }
        //If outside borders down left corner
        else if (player.transform.position.y < minPositionY && player.transform.position.x < minPositionX)
        {
            transform.position = new Vector3(minPositionX, minPositionY, -10);
        }
        //If outside borders down right corner
        else if (player.transform.position.y < minPositionY && player.transform.position.x > maxPositionX)
        {
            transform.position = new Vector3(maxPositionX, minPositionY, -10);
        }
        //if outside of boundries up or down
        else if (player.transform.position.y > maxPositionY||player.transform.position.y<minPositionY)
        {
            transform.position = new Vector3(player.position.x, transform.position.y, -10);
        }
       //If outside of boundries left or right
        else if (player.transform.position.x > maxPositionX || player.transform.position.x < minPositionX)
        {
            transform.position = new Vector3(transform.position.x, player.position.y, -10);
        }

      
    }
}
