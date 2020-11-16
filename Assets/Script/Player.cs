using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HTC.UnityPlugin.Vive;
using UnityEngine.Playables;


public class Player : MonoBehaviour
{
    // 弹幕间隔时间
    public float currentTime ;
    // 弹幕计时
    private float invokeTime;
    public int Blood;
    public GameObject GameUI;
    AnimatorControl animatorc;
    public bool Isdie = false;
    public GameObject LeftGun;
    public GameObject RightGun;
    //public Gun LeftGun;
    //public Gun RightGun;
    void Start()
    {
        
        currentTime = LeftGun.GetComponent<Gun>().currentTime;
        invokeTime = currentTime;
        animatorc = GetComponent<AnimatorControl>();
        Isdie = false;
    }
    void Update()
    {

        // StartCoroutine(cutblood());

        if (Input.GetKey(KeyCode.Z))
        {
            Blood--;
        }
        Debug.Log(Blood);
        //射线检测
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        if (Physics.Raycast(transform.position, fwd, out hit, 10000))
        {
            Debug.DrawLine(transform.position, hit.point, Color.red);
          
            if (ViveInput.GetPressDownEx(HandRole.RightHand, ControllerButton.PadTouch) && hit.transform.tag == "Story")     //按下菜单键并且射线指向商店
            {
                Debug.Log("打开商店");

            }
            if (VivePose.IsValidEx(HandRole.LeftHand) && VivePose.IsValidEx(TrackerRole.Tracker1))     //左手上的UI开关
            {
                GameUI.SetActive(!GameUI.activeSelf);

            }

        }

        //移动至Gun中发射子弹
        //if (ViveInput.GetPressDownEx(HandRole.RightHand, ControllerButton.Trigger) && !GameUI.activeSelf)     //右手发射子弹
        //{

        //    RightGun.Shoot();
        //}

        //if (ViveInput.GetPressDownEx(HandRole.LeftHand, ControllerButton.Trigger) && !GameUI.activeSelf)     //左手发射子弹
        //{
        //    LeftGun.Shoot();

        //}

        if (ViveInput.GetPressEx(HandRole.RightHand, ControllerButton.Trigger) /*&& !GetComponent<Player>().GameUI.activeSelf*/)  //右手发射子弹 (Input.GetKey(KeyCode.Z)) 
        {
            invokeTime += Time.deltaTime;
            if (invokeTime - currentTime > 0)
            {
                RightGun.GetComponent<Gun>().Shoot();
               

                // BulletPool.Instance.CreateObject("bullet", BulletPrefab, null, this.transform.position, this.transform.rotation, "Bullet");   
                invokeTime = 0;
            }
        }

        if (ViveInput.GetPressUpEx(HandRole.RightHand, ControllerButton.Trigger) /*&& !GetComponent<Player>().GameUI.activeSelf*/)     //右手发射子弹 Input.GetKeyUp(KeyCode.Z)
        {
            invokeTime = currentTime;
        }

        

        if (ViveInput.GetPressEx(HandRole.LeftHand, ControllerButton.Trigger)/*&& !GetComponent<Player>().GameUI.activeSelf*/)     //左手发射子弹 Input.GetKey(KeyCode.M)
        {
            invokeTime += Time.deltaTime;
            if (invokeTime - currentTime > 0)
            {
                LeftGun.GetComponent<Gun>().Shoot();
                //BulletPool.Instance.CreateObject("bullet", BulletPrefab, null, this.transform.position, this.transform.rotation, "Bullet");
                invokeTime = 0;
            }
        }

        if (ViveInput.GetPressUpEx(HandRole.LeftHand, ControllerButton.Trigger)/*&& !GetComponent<Player>().GameUI.activeSelf*/)     //左手发射子弹 Input.GetKeyUp(KeyCode.M)
        {
            invokeTime = currentTime;
        }
        if (Blood <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
        Isdie = true;
        animatorc.Play();

    }
    IEnumerator cutblood()
    {
        yield return new WaitForSeconds(2);
        Blood--;
    }
}