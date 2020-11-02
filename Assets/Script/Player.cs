using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HTC.UnityPlugin.Vive;
using UnityEngine.Playables;

public class Player : MonoBehaviour
{
    public int Blood;
    void Start()
    {

    }
    void Update()
    {
        //射线检测
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, out hit, 10000))
        {

            Debug.DrawLine(transform.position, hit.point, Color.red);
            Debug.Log("射线检测到的物体名称: " + hit.transform.name);
            if (ViveInput.GetPressDownEx(HandRole.RightHand, ControllerButton.Trigger) )     //检测手柄
            {

            }

        }
        if (ViveInput.GetPressDownEx(HandRole.RightHand, ControllerButton.Trigger))
        {

        }
    }
}