using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed ;
    public int hitflood ;
    Rigidbody rigidbody;
    public GameObject enemycollider;
    public int bulletlable;
    //public GameObject target;
    float BoomTime=0;
    public GameObject HitEffect;//碰撞特效
    public AudioClip ExplosionClip;
    
   
    void Start()
    {

      
        StartCoroutine(TimeDown());

        rigidbody = GetComponent<Rigidbody>();

    }
   

    // Update is called once per frame
    void Update()
    {

        //rigidbody.velocity = transform.forward * speed;

       
            this.transform.position += transform.forward * speed * Time.deltaTime;
        
    }
    //public abstract void Create();
    public  void Create()
    {
        //var angle = Math.Atan2(target.transform.position.y - transform.position.y, target.transform.position.x - transform.position.x);
        //var theta = angle * (180 / Math.PI);
        
        //Quaternion qua = Quaternion.Euler(transform.TransformDirection(Vector3.forward));
        //BulletPool.Instance.CreateObject("bullet", gameObject, null, this.transform.position, this.transform.rotation,gameObject.name);
     
    }
    public virtual void OnTriggerEnter(Collider other)
    {

        if(other.tag=="enemy"&&other.GetComponent<Enemy>().lable==bulletlable)
        {
            Debug.Log("111");
            BulletPool.Instance.CollectObject(this.gameObject);
            other.gameObject.GetComponent<Enemy>().blood -= hitflood;
            //扣血
            AudioSource.PlayClipAtPoint(ExplosionClip, transform.position);
            GameObject.Instantiate(HitEffect);
        }
       
    }
    IEnumerator TimeDown()
    {
        yield return new WaitForSeconds(4);
        BulletPool.Instance.CollectObject(this.gameObject);
       /// Debug.Log("我走了，别想我");
    }

}
