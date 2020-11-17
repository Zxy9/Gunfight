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
    int lable=0;
    
    
    // Start is called before the first frame update
    void Start()
    {   
        Earth = GameObject.Find("EA").transform.GetChild(0).gameObject;
        Move();
    }
    // Update is called once per frame
    void Update()
    {
        
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
