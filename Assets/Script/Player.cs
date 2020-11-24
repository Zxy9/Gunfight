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
    public GameObject[] LeftGun;
    public GameObject[] RightGun;
    public int GunNumber=0;
    float CT;//计算射速
    public int UseBulletCount = 0;
    public GameObject LeftBeam;
    public GameObject RightBeam;
    public GameObject[] Audio;
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
            if (CT >= RightGun[GunNumber].GetComponent<Gun>().currentTime)
            {
                if (GunNumber == 1)
                {
                    Audio[0].SetActive(true);
                    Audio[1].SetActive(true);
                    Audio[2].SetActive(false);
                    RightBeam.SetActive(true);
                    RightGun[GunNumber].GetComponent<RayIn>().BeamShoot();
                }
                else
                {
                    RightGun[GunNumber].GetComponent<Gun>().Shoot();
                }
                UseBulletCount++;
                CT =0;
            }
        }
        if (ViveInput.GetPressUpEx(HandRole.RightHand, ControllerButton.Trigger) && GunNumber == 1)
        {
            Audio[0].SetActive(false);
            Audio[1].SetActive(false);
            Audio[2].SetActive(true);
            RightBeam.SetActive(false);
        }
            if (ViveInput.GetPressEx(HandRole.LeftHand, ControllerButton.Trigger) /*&& !GameUI.activeSelf*/)     //左手发射子弹
        {
            CT += Time.deltaTime;
            if (CT >= LeftGun[GunNumber].GetComponent<Gun>().currentTime)
            {
                if (GunNumber == 1)
                {
                    Audio[3].SetActive(true);
                    Audio[4].SetActive(true);
                    Audio[5].SetActive(false);
                    LeftBeam.SetActive(true);
                    LeftGun[GunNumber].GetComponent<RayIn>().BeamShoot();
                }
                else
                {
                    LeftGun[GunNumber].GetComponent<Gun>().Shoot();
                }
                UseBulletCount++;
                CT = 0;
            }
        }
        if (ViveInput.GetPressUpEx(HandRole.LeftHand, ControllerButton.Trigger) && GunNumber == 1)
        {
            Audio[3].SetActive(false);
            Audio[4].SetActive(false);
            Audio[5].SetActive(true);
            LeftBeam.SetActive(false);
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