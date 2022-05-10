using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ChangeCubeColourDE.onActionButtonClick += ToFallDown;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToFallDown()
    {
        GetComponent<Rigidbody>().useGravity = true;
    }
}
//Create a program using delgates and events, where you hit the space key, I want to change 
//Cube position to (5,5,5), the cube script should subscribe to the event and invoke when you hit hte space key.
