using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal")*3f*Time.deltaTime;
        float inputY = Input.GetAxis("Vertical")*3f*Time.deltaTime;
        transform.Translate(inputX, inputY, 0f);
    }
}
