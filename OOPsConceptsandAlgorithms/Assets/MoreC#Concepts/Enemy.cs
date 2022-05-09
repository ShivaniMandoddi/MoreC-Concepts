using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public int speed;
    public int health;
    public abstract void Attack();
    public virtual void Die()
    {
        Debug.Log("I am Dead");
    }
    
}
public class Robot: Enemy
{
   public override void Attack()
    {
        Debug.Log("This is Attack Method");
    }
    public override void Die()
    {
        base.Die();
    }
    /*
    public void Damage(int f)
    {
        Debug.Log("The passed value: ")
    }*/
}
