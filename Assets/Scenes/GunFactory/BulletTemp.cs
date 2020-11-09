using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

    public class BulletTemp:MonoBehaviour
{
      
    public  float speed;
    public  float hurtValue;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

    }
    private void OnCollisionEnter(Collision collision)
    {
        Character tempCharacter = collision.collider.GetComponent<Character>();
        if (tempCharacter != null)
        {
            tempCharacter.blood -= hurtValue;
            Destroy(gameObject);
        }
       


    }
}
