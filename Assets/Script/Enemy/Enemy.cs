using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
class Enemy : MonoBehaviour
{
    public int blood;
    int Hit;
    int MoveSpeed;
    Rigidbody rigidbody;
    public GameObject AttackPoint;
    GameObject Earth;
    
    // Start is called before the first frame update
    void Start()
    {
        Earth = GameObject.Find("EA");
       // Move();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void Attack()
    {
        AttackPoint.GetComponent<Bullet>().Create();

    }

    public virtual void Move()
    {
        transform.DOMove(Earth.transform.position, 3);//移动到地球中心
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Earth")
        {

            ProjectControl.EnemyInCount++;
            Destroy(gameObject);
        }
    }
}
