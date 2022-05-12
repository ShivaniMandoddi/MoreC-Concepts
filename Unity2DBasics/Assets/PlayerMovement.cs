using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool iscollecting = true;
    
    bool isalive = false;
    public Rigidbody2D rigidbody2D;
    Vector3 tempPosition;
    Queue<Vector3> toCollect=new Queue<Vector3> ();
    void Start()
    {
        iscollecting = true;
    }

    // Update is called once per frame
    void Update()
    {
        /*float inputX = Input.GetAxis("Horizontal")*3f*Time.deltaTime;
        float inputY = Input.GetAxis("Vertical")*3f*Time.deltaTime;
        transform.Translate(inputX, inputY, 0f);*/
        if (Input.GetMouseButtonDown(0))
        {
            isalive = true;
        }
        if(isalive)
        {
            Debug.Log("I am ready to follow ");
            
            GotoTargetPickUp(tempPosition);
        }
        if(iscollecting && toCollect.Count>0)
        {
            tempPosition = toCollect.Dequeue();
            
            Debug.Log("Tempposition form deque" + tempPosition);
        }
        if (toCollect.Count < 0)
        {
            isalive = false;
            iscollecting = true;
        }
        
    }
    public void TargetPresence(Vector3 temp)
    {
        Debug.Log(temp);
        toCollect.Enqueue(temp);
       
    }
    public void GotoTargetPickUp(Vector3 targetPickup)
    {
        iscollecting = false;
        Vector2 direction = new Vector2(
        targetPickup.x - transform.position.x,
          targetPickup.y - transform.position.y);
        direction.Normalize();
        rigidbody2D.velocity = Vector2.zero;
        rigidbody2D.AddForce(direction * 3f,             //ImpulseForceMagnitude,
        ForceMode2D.Impulse);
        //rigidbody2D.velocity =  targetToFollow* 80f * Time.deltaTime;
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "PickUp")
        {
            iscollecting=false;
            col.gameObject.SetActive(false);
            tempPosition = toCollect.Dequeue();
            
        }
    }


}
