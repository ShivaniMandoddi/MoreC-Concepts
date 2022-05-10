using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        
        ChangeCubeColourDE.onActionButtonClick+=ToTurnRed;

       

    }
    public void ToTurnRed()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
    public void ToTurnBlue()
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }
    public void OnDisable()
    { 
        Debug.Log("Disable in disable method");
        ChangeCubeColourDE.onActionButtonClick -= ToTurnRed;
        ChangeCubeColourDE.onActionButtonClick += ToTurnBlue;
    }
    private void OnEnable()
    {
        ChangeCubeColourDE.onActionButtonClick += ToTurnRed;
        ChangeCubeColourDE.onActionButtonClick -= ToTurnBlue;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
