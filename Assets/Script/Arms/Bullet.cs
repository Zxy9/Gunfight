using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed ;
    public int hitflood ;
    Rigidbody rigidbody;

    void Start()
    {

      
        StartCoroutine(TimeDown());
       


    }
   

    // Update is called once per frame
    void Update()
    {

        this.transform.position += transform.forward * speed * Time.deltaTime;
      
    }
    //public abstract void Create();
    public  void Create()
    {
       // BulletPool.Instance.CreateObject("bullet", bulletgameobject, null, this.transform.position,this.transform.rotation,this.gameObject.name);
     
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy")
        {
           
            BulletPool.Instance.CollectObject(this.gameObject);
            other.gameObject.GetComponent<Enemy>().blood -= hitflood;
            //扣血
        }
       
    }
    IEnumerator TimeDown()
    {
        yield return new WaitForSeconds(4);
        BulletPool.Instance.CollectObject(this.gameObject);
    }

}
