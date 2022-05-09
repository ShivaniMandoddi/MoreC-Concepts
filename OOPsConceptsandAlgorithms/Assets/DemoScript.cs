using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyNewNamespace;
using MyNewNamespace.MyUI;

// namespace is a keyword, where it uses before the namespace
//syntax: namespace name{}
public class DemoScript : MonoBehaviour
{
    public MyNameSpaceClass spaceClass = new MyNameSpaceClass();
    // Start is called before the first frame update
    void Start()
    {
        
        MyNameSpaceClass.MyPrint();
        MyUIClass.MyPrintUI();
        Debug.Log(spaceClass.playerSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
