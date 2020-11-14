using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Gun : MonoBehaviour
{
    // Start is called before the first frame update
    int Hit;
    int ShootSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public  virtual void BulletCreate()
    {
        Bullet bullet = new Bullet();
        bullet.Create();
    }
    
}
