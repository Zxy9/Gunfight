using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class  Enemy1 : Enemy
{
    // Start is called before the first frame update
    public int Blood;
    int Hit;
    int MoveSpeed;
    Rigidbody rigidbody;
  
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Attack()
    {

        Gun gun = GetComponent<Gun>();
        gun.BulletCreate();

    }
    public override void Move()
    {
        Vector3 vector3 = new Vector3(0, Time.deltaTime * MoveSpeed, 0);
        rigidbody.velocity = vector3; 
        
    }
}
