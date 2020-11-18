using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ProjectControl : UnitySingle<ProjectControl>
{
    // Start is called before the first frame update
    public Player player;
    AnimatorControl animatorVictory;
    public GameObject VictoryInterface;
    AnimatorControl animatorFail;
    public GameObject FailInterface;
    public int EnemyCount=0;//现有敌人数量
    public static int EnemyInCount=0;
    public int EnemyInMax = 10;//基地最大入侵敌人数量
    public static int Money = 0;
    public GameObject[] Enemy;
    float j=0;//用于计算每个敌人出现时间
    float w = 0;//用于计算狂暴敌人出现时间
    float End = 0;//计算结束时间
    float i = 2;//每个敌人出现的时间

    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (player.Isdie == true)
        {
            Victory();
        }
        j += Time.deltaTime; 
        if (j>=i)
        {
            GameObject.Instantiate(Enemy[Random.Range(0,3)], new Vector3(Random.Range(-40, 40), Random.Range(-20, 20), 80), transform.rotation);
            EnemyCount++;//现有敌人数量+1
            j = 0;
        }
        w += Time.deltaTime;
        if (w >= 10)//狂暴时间
        {
            i = 1;//缩短敌人刷新时间
            if (w >= 20)//狂暴持续时间
            {
                w = 0;//重置狂暴时间
                i = 1;//重置敌人刷新时间
            }
        }
        End += Time.deltaTime;
        if (End >= 30)//游戏结束
        {
            i = 10000000;
        }
        if (End >= 30 && EnemyCount == 0)//胜利检测
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
        //animatorVictory.Play();
        VictoryInterface.SetActive(true);
    }
    void Fail()
    {
        //animatorFail.Play();
        FailInterface.SetActive(true);
    }



}
