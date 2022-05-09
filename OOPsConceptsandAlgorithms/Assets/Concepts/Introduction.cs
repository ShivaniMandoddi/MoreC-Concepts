using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Introduction : MonoBehaviour
{
    // Start is called before the first frame update
    //Checking Radius and Area Info
    void Start()
    {
        
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("Radius :" + i + ", Area: " + (Mathf.PI * 2 * i));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
