using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HTC.UnityPlugin.Vive;
using UnityEngine.Playables;

public class RayIn : MonoBehaviour
{
   

    void Start()
    {

    }
    void Update()
    {
        //射线检测
        //RaycastHit hit;
        //Vector3 fwd = transform.TransformDirection(Vector3.forward);

        //if (Physics.Raycast(transform.position, fwd, out hit, 10000))
        //{

        //    Debug.DrawLine(transform.position, hit.point, Color.red);
        //    Debug.Log("射线检测到的物体名称: " + hit.transform.name);
        //    if (Right)
        //    {
        //        if (ViveInput.GetPressEx(HandRole.RightHand, ControllerButton.Trigger) && hit.transform.tag == "enemy" && hit.transform.GetComponent<Enemy>().lable == 1)     //检测手柄
        //        {
        //            hit.transform.GetComponent<Enemy>().blood -= 25;
        //        }
        //    }
        //    else
        //    {
        //        if (ViveInput.GetPressEx(HandRole.LeftHand, ControllerButton.Trigger) && hit.transform.tag == "enemy" && hit.transform.GetComponent<Enemy>().lable == 1)     //检测手柄
        //        {
        //            hit.transform.GetComponent<Enemy>().blood -= 25;
        //        }
        //    }
        //}
    }
    public void BeamShoot()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, out hit, 200))
        {
            Debug.DrawLine(transform.position, hit.point, Color.red); 
                if ( hit.transform.tag == "enemy" && hit.transform.GetComponent<Enemy>().lable == 1)     //检测手柄
                {
                    hit.transform.GetComponent<Enemy>().blood -= 25;
                }
            
        }
    }
}