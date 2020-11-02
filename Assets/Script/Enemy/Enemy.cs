using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class Enemy : MonoBehaviour
{
    public int blood;
    int Hit;
    int MoveSpeed;
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public abstract void Attack();
  
    public abstract void Move();
}
