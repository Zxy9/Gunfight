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
    public Gun[] LeftGun;
    public Gun[] RightGun;
    public int GunNumber=0;
    float CT;//计算射速
    public int UseBulletCount = 0;
    public GameObject LeftBeam;
    public GameObject RightBeam;
    void Start()
    {

        animatorc = GetComponent<AnimatorControl>();
        Isdie = false;
    }
    void Update()
    {
        if (GunNumber >=RightGun.Length)
        {
            GunNumber = 0;
        }
         if (ViveInput.GetPressDownEx(HandRole.LeftHand,ControllerButton.Menu))     //左手上的UI开关
         {
                Debug.Log("menu");
                GameUI.SetActive(!GameUI.activeSelf);
         }
       
        
        
        if (ViveInput.GetPressEx(HandRole.RightHand, ControllerButton.Trigger) /*&& !GameUI.activeSelf*/)     //右手发射子弹
        {
            CT+=Time.deltaTime;
            if (CT >= RightGun[GunNumber].currentTime)
            {
                if (GunNumber == 1)
                {
                    RightBeam.SetActive(true);
                    RightGun[GunNumber].GetComponent<RayIn>().BeamShoot();
                }
                else
                {
                    RightGun[GunNumber].Shoot();
                }
                UseBulletCount++;
                CT =0;
            }
        }
        if (ViveInput.GetPressUpEx(HandRole.RightHand, ControllerButton.Trigger) && GunNumber == 1)
        {
            RightBeam.SetActive(false);
        }
            if (ViveInput.GetPressEx(HandRole.LeftHand, ControllerButton.Trigger) /*&& !GameUI.activeSelf*/)     //左手发射子弹
        {
            CT += Time.deltaTime;
            if (CT >= LeftGun[GunNumber].currentTime)
            {
                if (GunNumber == 1)
                {
                    LeftBeam.SetActive(true);
                    LeftGun[GunNumber].GetComponent<RayIn>().BeamShoot();
                }
                else
                {
                    LeftGun[GunNumber].Shoot();
                }
                UseBulletCount++;
                CT = 0;
            }
            if (ViveInput.GetPressUpEx(HandRole.LeftHand, ControllerButton.Trigger) && GunNumber == 1)
            {
                LeftBeam.SetActive(false);
            }

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