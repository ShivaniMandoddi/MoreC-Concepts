using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawingObjects : MonoBehaviour
{
    // Start is called before the first frame update
    float minspawnX;
    float maxspawnX;
    float minspawnY;
    float maxspawnY;
    public GameObject objectPrefab;
    float time;
    List<GameObject> pickupPrefabs=new List<GameObject> ();
    void Start()
    {
        minspawnX = 0f;
        minspawnY = 0f;
        maxspawnX = Screen.width;
        maxspawnY = Screen.height;
        Debug.Log(maxspawnX);
        Debug.Log(maxspawnY);
        for (int i = 0; i < 10; i++)
        {
            GameObject temp= Instantiate(objectPrefab);
            pickupPrefabs.Add(temp);
            temp.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*
       time = time + Time.deltaTime;
        if(time>=2f)
        {
           Vector3 newPosition = new Vector3(Random.Range(minspawnX, maxspawnX), Random.Range(minspawnY, maxspawnY), -transform.position.z);
            Vector3 convertedPosition = Camera.main.ScreenToWorldPoint(newPosition);
            Instantiate(objectPrefab, convertedPosition, Quaternion.identity);
            time = 0f;
        }*/
        if(Input.GetMouseButtonDown(1))
        {
           Vector3 screenPosition=Input.mousePosition;
            Vector3 tempPosition = Camera.main.ScreenToWorldPoint(screenPosition);
            GameObject temp= GetObjectFromList();
            
            if (temp != null)
            {
                temp.SetActive(true);
                tempPosition.z = temp.transform.position.z;
                temp.transform.position = tempPosition;
                GameObject.Find("Player").GetComponent<PlayerMovement>().TargetPresence(temp.transform.position);
            }


        }
       
    }

    private GameObject GetObjectFromList()
    {
        foreach (GameObject item in pickupPrefabs)
        {
            if (item.activeInHierarchy == false)
                return item;

        }
        return null;
    }
    
}
