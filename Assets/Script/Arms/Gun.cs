using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun:MonoBehaviour
{
    public GameObject BulletPrefab;//不同子弹设置不同的伤害值，将子弹作为预制体
    // 弹幕间隔时间
    public float currentTime = 0.1f;
    // 弹幕计时
    private float invokeTime;
   
    void Start()
    {
        invokeTime = currentTime;
    }
    public void Update()
    {
        if (GunUIController.Instance.Count > 0)
        {
            Shoot();

        }
    }
    public  void Shoot()
    {
       
        if (Input.GetKey(KeyCode.Z))
        {
            invokeTime += Time.deltaTime;
            if (invokeTime - currentTime > 0)
            {
                BulletPool.Instance.CreateObject("bullet", BulletPrefab, null, this.transform.position, this.transform.rotation, "Bullet");
                GunUIController.Instance.AutoAdd();
                invokeTime = 0;
            }
        }
       
        if (Input.GetKeyUp(KeyCode.Z))
        {
            invokeTime = currentTime;
        }



        
    }
    

  
}
