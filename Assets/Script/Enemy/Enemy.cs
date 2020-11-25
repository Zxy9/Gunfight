using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
class Enemy : MonoBehaviour
{
    public int blood;
    public int MoveSpeed1;
    public int MoveSpeed2;
    public GameObject AttackPoint;
    GameObject Earth;
    public  int lable=0;
    public GameObject BoomEffect;
    public GameObject BoomAudio;
    
    // Start is called before the first frame update
    void Start()
    {   
        Earth = GameObject.Find("EA").transform.GetChild(0).gameObject;
        Move();
    }
    // Update is called once per frame
    void Update()
    {
        if (blood == 0)
        {
            ProjectControl.EnemyKill++;
            GameObject.Instantiate(BoomEffect, transform.position, transform.rotation);
            GameObject.Instantiate(BoomAudio, transform.position, transform.rotation);
            ProjectControl.Money+=50;
            Destroy(gameObject);
        }
    }
    public  void Attack()
    {
        AttackPoint.GetComponent<Bullet>().Create();
    }
    
    public  void Move()
    {
        transform.DOMove((transform.position-Earth.transform.position)/3, 100 / MoveSpeed1);
       
        transform.DOMove(Earth.transform.position, 100 / MoveSpeed2)
            .SetDelay(3)
            .OnComplete(()=>
            {
                ProjectControl.EnemyInCount++;
                Destroy(gameObject);
            }
            );
        
    }

   
}
