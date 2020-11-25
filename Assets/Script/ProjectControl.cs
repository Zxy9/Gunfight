using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class ProjectControl : UnitySingle<ProjectControl>
{
    // Start is called before the first frame update
    public Player player;

    //public GameObject VictoryInterface;

    //public GameObject FailInterface;
    public int EnemyCount=0;//现有敌人数量
    public static int EnemyKill = 0;//杀敌数
    public static int EnemyInCount=0;
    public int EnemyInMax = 10;//基地最大入侵敌人数量
    public static int Money = 0;
    public GameObject[] Enemy;
    float j=0;//用于计算每个敌人出现时间
    float w = 0;//用于计算狂暴敌人出现时间
    float End = 0;//计算结束时间
    float i = 2;//每个敌人出现的时间
    
    public GameObject CameraFail;
    public Vector3 CameraFailRotate;
    public GameObject FailScenes;
    public GameObject VictoryScenes;
    public Text MoneyText;
    public Text KillText;
    public Text InCountText;
    public Text WaveText;

    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        MoneyText.text = Money.ToString();
        KillText.text = EnemyKill.ToString();
        InCountText.text = EnemyInCount.ToString();
        MoneyText.text = Money.ToString();
        if (player.Isdie == true)
        {
            Victory();
        }
        j += Time.deltaTime; 
        if (j>=i)
        {
            GameObject.Instantiate(Enemy[Random.Range(0,3)], new Vector3(Random.Range(-10, 10), Random.Range(0, 15), 30), transform.rotation);
            EnemyCount++;//现有敌人数量+1
            j = 0;
        }
        w += Time.deltaTime;
        if (w >= 30)//狂暴时间
        {
            i = 1.5f;//缩短敌人刷新时间
            if (w >= 40)//狂暴持续时间
            {
                w = 0;//重置狂暴时间
                i = 2;//重置敌人刷新时间
            }
        }
        End += Time.deltaTime;
        if (End >= 180)//游戏结束
        {
            i = 10000000;
        }
        if (End >= 180 && EnemyCount == 0)//胜利检测
        {
            Victory();
        }
        if (EnemyInCount >= EnemyInMax)//敌人入侵地球检测
        {
            Fail();
        }
    }

    void Victory()
    {
        VictoryScenes.GetComponent<ScenceControl>().LoadSneneN();
        //animatorVictory.Play();
        //VictoryInterface.SetActive(true);
    }
    void Fail()
    {
        Destroy(player.gameObject);
        CameraFail.SetActive(true);
        CameraFail.transform.DORotate(CameraFailRotate, 2f).
            OnComplete(()=>
            {
                FailScenes.GetComponent<ScenceControl>().LoadSneneN();
            });
        //animatorFail.Play();
        //FailInterface.SetActive(true);
    }



}
