using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ChangingCubePostion.onSpaceClick += ChangePosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangePosition()
    {
        transform.position = new Vector3(5, 5, 5);
    }
}
