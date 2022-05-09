using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Item> itemList = new List<Item>();
    public Dictionary<int, Item> itemDictionary = new Dictionary<int, Item>();
    void Start()
    {
        Item mySword = new Item();
        mySword.name = "Knife";
        mySword.id = 2;

        Item myBullet = new Item();
        myBullet.name = "bullet";
        myBullet.id = 4;

        Item myCar = new Item();
        myCar.name = "Car";
        myCar.id = 6;

        itemDictionary.Add(0, mySword);
        itemDictionary.Add(1, myBullet);
        itemDictionary.Add(2, myCar);

        itemList.Add(mySword);
        itemList.Add(myBullet);
        itemList.Add(myCar);
        // To pint the list
        /*foreach (var item in itemList)
        {
            Debug.Log(item.name);
            Debug.Log(item.id);
        }*/
        // To Print dictionary
        /*foreach (KeyValuePair<int,Item> item in itemDictionary)
        {
            Debug.Log("Key: "+item.Key);
            Debug.Log("Value: " + item.Value.name);
        }*/
        // Printing only keys
        /*foreach (int item in itemDictionary.Keys)
        {
            Debug.Log("Keys: "+item);
        }*/
        //Printing only values
        /*foreach (Item item in itemDictionary.Values)
        {
            Debug.Log("Values: "+item.name);
        }*/

       // Acessing value through key
       //var myDictionaryItem = itemDictionary[0];


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
