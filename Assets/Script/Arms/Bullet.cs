using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed ;
    public int hitflood ;

    void Start()
    {
        
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
            Debug.Log("111碰撞");
            BulletPool.Instance.CollectObject(this.gameObject);
            //other.gameObject.GetComponent<Enemy>().flood -= hitflood;
            //扣血
        }
        else
        {
           
            TimeDown();
            BulletPool.Instance.CollectObject(this.gameObject);
            
        }
    }
    IEnumerator TimeDown()
    {
        yield return new WaitForSeconds(2);
    }
}
