using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayerNameAndAge : MonoBehaviour
{
    public Dictionary<string, int> footballPlayer = new Dictionary<string, int>();
    void Start()
    {
        footballPlayer.Add("Marc", 15);
        footballPlayer.Add("John", 20);
        footballPlayer.Add("Jinv", 26);
        footballPlayer.Add("Kev", 30);

        var footballPlayerAge = footballPlayer["Kev"];
        Debug.Log(footballPlayerAge);
        foreach (KeyValuePair<string,int> item in footballPlayer)
        {
            Debug.Log(item.Value);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
