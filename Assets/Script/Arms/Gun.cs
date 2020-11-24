using HTC.UnityPlugin.Vive;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun:MonoBehaviour
{
   // public GameObject effectPrefab;
    // 弹幕间隔时间
    public float currentTime = 0.1f;
    // 弹幕计时
    //private float invokeTime;
    public GameObject BulletPrefab;//不同子弹设置不同的伤害值，将子弹作为预制体
   
   
    void Start()
    {
        
    }
    public void Update()
    {
       
           // Shoot();
        

        
    }
    public  void Shoot()
    {
        //if (ViveInput.GetPressEx(HandRole.RightHand, ControllerButton.Trigger) /*&& !GetComponent<Player>().GameUI.activeSelf*/)  //右手发射子弹 (Input.GetKey(KeyCode.Z)) 
        //{
        //    invokeTime += Time.deltaTime;
        //    if (invokeTime - currentTime > 0)
        //    {
        BulletPool.Instance.CreateObject("bullet", BulletPrefab, null, this.transform.position, this.transform.rotation, BulletPrefab.name);
        
       // effectPrefab.SetActive(true);
        //BulletPrefab.GetComponent<Bullet>().Create();
        //        // BulletPool.Instance.CreateObject("bullet", BulletPrefab, null, this.transform.position, this.transform.rotation, "Bullet");   
        //        invokeTime = 0;
        //    }
        //}

        //if (ViveInput.GetPressUpEx(HandRole.RightHand, ControllerButton.Trigger) /*&& !GetComponent<Player>().GameUI.activeSelf*/)     //右手发射子弹 Input.GetKeyUp(KeyCode.Z)
        //{
        //    invokeTime = currentTime;
        //}





        //if (ViveInput.GetPressEx(HandRole.LeftHand, ControllerButton.Trigger)/*&& !GetComponent<Player>().GameUI.activeSelf*/)     //左手发射子弹 Input.GetKey(KeyCode.M)
        //{
        //    invokeTime += Time.deltaTime;
        //    if (invokeTime - currentTime > 0)
        //    {
        //        BulletPrefab.GetComponent<Bullet>().Create();
        //        //BulletPool.Instance.CreateObject("bullet", BulletPrefab, null, this.transform.position, this.transform.rotation, "Bullet");
        //        invokeTime = 0;
        //    }
        //}

        //if (ViveInput.GetPressUpEx(HandRole.LeftHand, ControllerButton.Trigger)/*&& !GetComponent<Player>().GameUI.activeSelf*/)     //左手发射子弹 Input.GetKeyUp(KeyCode.M)
        //{
        //    invokeTime = currentTime;
        //}



    }
    

  
}
