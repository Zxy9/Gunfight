using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HTC.UnityPlugin.Vive;
using UnityEngine.Playables;


public class Player : MonoBehaviour
{
    public int Blood;
    public GameObject GameUI;
    AnimatorControl animatorc;
    public bool Isdie = false;
    public Gun LeftGun;
    public Gun RightGun;
    float CT;//计算射速
    void Start()
    {

        animatorc = GetComponent<AnimatorControl>();
        Isdie = false;
    }
    void Update()
    {
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
            if (ViveInput.GetPressDownEx(HandRole.LeftHand,ControllerButton.Menu))     //左手上的UI开关
            {
                Debug.Log("menu");
                GameUI.SetActive(!GameUI.activeSelf);
            }

        }
        if (ViveInput.GetPressEx(HandRole.RightHand, ControllerButton.Trigger) && !GameUI.activeSelf)     //右手发射子弹
        {
            CT+=Time.deltaTime;
            if (CT >= RightGun.currentTime)
            {
                RightGun.Shoot();
                CT =0;
            }
        }
        if (ViveInput.GetPressEx(HandRole.LeftHand, ControllerButton.Trigger) && !GameUI.activeSelf)     //左手发射子弹
        {
            LeftGun.Shoot();

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
}