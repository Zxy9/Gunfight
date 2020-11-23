﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//状态效果值
public enum FadeStatuss
{
    FadeIn,
    FadeOut
}

public class FadeIn : MonoBehaviour
{
    //设置的图片
    public Image m_Sprite;
    //透明值
    private float m_Alpha;
    //淡入淡出状态
    private FadeStatuss m_Statuss;
    //效果更新的速度
    public float m_UpdateTime;
    Color ss;
    // Use this for initialization
    void Start()
    {
        //默认设置为淡入效果
        m_Statuss = FadeStatuss.FadeOut;
        m_Alpha = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //控制透明值变化
        if (m_Statuss == FadeStatuss.FadeOut)
        {
            m_Alpha -= m_UpdateTime * Time.deltaTime;
        }

        UpdateColorAlpha();
    }

    void UpdateColorAlpha()
    {
        //获取到图片的透明值
        ss = m_Sprite.color;
        ss.a = m_Alpha;
        //将更改过透明值的颜色赋值给图片
        m_Sprite.color = ss;
        //透明值等于的1的时候 转换成淡出效果
         if (m_Alpha <=0f)
        {
            Destroy(gameObject);
        }

       
    }
}
