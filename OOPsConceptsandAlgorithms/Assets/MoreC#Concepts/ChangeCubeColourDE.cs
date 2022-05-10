using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCubeColourDE : MonoBehaviour
{
    public delegate void ActionButtonClick();
    public static event ActionButtonClick onActionButtonClick;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void CubeColourChange()
    {
        if(onActionButtonClick!=null)
        {
            onActionButtonClick();
        }
    }
   
}
