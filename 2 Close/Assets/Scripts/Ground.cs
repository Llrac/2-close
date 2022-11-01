using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        float width = Camera.main.orthographicSize * Camera.main.aspect;
        float height = Camera.main.orthographicSize;
        transform.position = Vector2.zero;
        transform.localScale = new Vector2(width * 2, height * 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
