using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingCubePostion : MonoBehaviour
{
    public delegate void ActionClick();
    public static event ActionClick onSpaceClick;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(onSpaceClick!=null)
            {
                onSpaceClick();
            }
        }
    }
}
