using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class GunUIController : MonoBehaviour
{
    private static GunUIController _instance;

    public static GunUIController Instance
    {
        get
        {
            if (_instance != null)
            {
                return _instance;
            }
            else
            {
                return null;
            }
        }
    }

    [Header("把Canvas/Panel/Text预制体拉到这")]
    public Text CountText;


    [Header("子弹总数")]
    public int Count;

    void Awake()
    {
        _instance = this;
       
    }
    public void AutoAdd()
    {
        CountText.text = "弹药:" + --Count;
    }
}
