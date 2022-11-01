using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    float y = 0;
    float x = 0;
    float Speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {

        //Movement
        x += Input.GetAxis("Horizontal") * Time.deltaTime * Speed;
        y += Input.GetAxis("Vertical") * Time.deltaTime * Speed;

        transform.position = new Vector3(x, y);
    }
}
