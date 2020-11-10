using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFactory:MonoBehaviour
{
    public GameObject BulletPrefab;//不同子弹设置不同的伤害值，将子弹作为预制体
   
   
    
    private void Start()
    {
        
    }

    public  void Shoot()
    {
       

        if (Input.GetKeyDown(KeyCode.J))
        {
          
            GameObject bullet = Instantiate(BulletPrefab, Vector3.zero, Quaternion.identity) as GameObject;
            

        }
    }
    public void ShootMutiple(float ShootSpeedMutiple, int HitMutiple)
    {
        BulletPrefab.GetComponent<BulletTemp>().speed = BulletPrefab.GetComponent<BulletTemp>().speed * ShootSpeedMutiple;
        BulletPrefab.GetComponent<BulletTemp>().hurtValue =BulletPrefab.GetComponent<BulletTemp>().hurtValue * HitMutiple;
    }
}
