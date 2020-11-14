using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

    public class BulletTemp:MonoBehaviour
{
      
    public  float speed;
    public  int hurtValue;
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
        Player tempCharacter = collision.collider.GetComponent<Player>();
        if (tempCharacter != null)
        {
            tempCharacter.Blood-= hurtValue;
            Destroy(gameObject);
        }
       


    }
}
