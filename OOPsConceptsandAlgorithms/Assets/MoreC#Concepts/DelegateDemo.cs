using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DelegateDemo : MonoBehaviour
{
    // Start is called before the first frame update
    public delegate void ChangeColour(Color newColor); //delegate should not be null
    public delegate void OnComplete();

    public ChangeColour onChangeColour;
    public OnComplete onChangeComplete;
    void Start()
    {
        onChangeColour = UpdateColour;   
        onChangeColour(Color.red);
        onChangeComplete += TaskCompleted;     //Multicasting one reference for more methods
        onChangeComplete+=TaskCompleted2;
        onChangeComplete += TaskCompleted3;
        onChangeComplete -= TaskCompleted3;
        if (onChangeComplete != null)
        {
            onChangeComplete();
        }
    }

    public  void TaskCompleted()
    {
        Debug.Log("Task Finished");
    }

    public void UpdateColour(Color newColour)
    {
        Debug.Log("Changing colour to : " + newColour.ToString());
    }
    public void TaskCompleted2()
    {
        Debug.Log("Task 2 Completed");
    }
    public void TaskCompleted3()
    {
        Debug.Log("Task 3 Completed");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
   
}
