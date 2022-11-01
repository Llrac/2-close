using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManagerScript : MonoBehaviour
    
{
    public TMP_Text detectionCircle;
    public float timeInCircle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        detectionCircle.text = "" + timeInCircle;
    }
}
