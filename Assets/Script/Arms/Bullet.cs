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

        Debug.Log("创建子弹");
        StartCoroutine(TimeDown());
        Debug.Log("等待几秒之后");
        //BulletPool.Instance.CollectObject(this.gameObject);
        Debug.Log("回收子弹");



    }
   

    // Update is called once per frame
    void Update()
    {

        this.transform.position += transform.forward * speed * Time.deltaTime;
        //Debug.Log("wozaiupdate");
        //StartCoroutine(TimeDown());
        //Debug.Log("等待几秒之后");
        //BulletPool.Instance.CollectObject(this.gameObject);
        //Debug.Log("回收子弹");
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
       
    }
    IEnumerator TimeDown()
    {
        yield return new WaitForSeconds(2);
        BulletPool.Instance.CollectObject(this.gameObject);
    }

}
