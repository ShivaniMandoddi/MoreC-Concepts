using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyInterfaceDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
public interface IDamage
{
    public int health { get; set; }
    void Damage(int damageAmount);
}