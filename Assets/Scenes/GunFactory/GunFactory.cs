using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFactory:MonoBehaviour
{
    public GameObject BulletPrefab;//不同子弹设置不同的伤害值，将子弹作为预制体
    //Bullet bullettemp=new Bullet();
    //public GameObject bulletgameobject;

    private void Start()
    {
        
    }

    public  void Shoot()
    {

       
        if (Input.GetKeyDown(KeyCode.J))
        {
           
            Debug.Log("12222");
            //GameObject bullet = Instantiate(BulletPrefab, Vector3.zero, Quaternion.identity) as GameObject;
            //BulletPrefab.GetComponent<Bullet>().Create();
            BulletPool.Instance.CreateObject("bullet", BulletPrefab, null, this.transform.position, this.transform.rotation,"Bullet");
            Debug.Log("2");

        }
    }
    public void ShootMutiple(float ShootSpeedMutiple, int HitMutiple)
    {
        BulletPrefab.GetComponent<Bullet>().speed = BulletPrefab.GetComponent<Bullet>().speed * ShootSpeedMutiple;
        BulletPrefab.GetComponent<Bullet>().hitflood =BulletPrefab.GetComponent<Bullet>().hitflood * HitMutiple;
    }
}
