﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;

public class InterFaceControl:MonoBehaviour
{
    public GameObject Beforepanel;
    public GameObject AfterPanel;
   
    private void Start()
    {
      
    }
    public void CloseInterface()
    {
        //关闭第一个界面
        Beforepanel.SetActive(false);
    }

    public void ShowInterface()
    {
        //打开第二个界面
        AfterPanel.SetActive(true);
      
    }
}