using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayer : MonoBehaviour
{
    public Dictionary<int, Player> playersDictionary = new Dictionary<int, Player>();
    void Start()
    {
        Player player1 = new Player(1);
        player1.name = "Shivani";
        Player player2 = new Player(20);
        player2.name = "Vyshnavi";
        Player player3 = new Player(15);
        player3.name = "Anusha";

        playersDictionary.Add(player1.id, player1);
        playersDictionary.Add(player2.id, player2);
        playersDictionary.Add(player3.id, player3);


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            var myDictionary=playersDictionary[1];
            Debug.Log(myDictionary.name);
        }
    }
}
