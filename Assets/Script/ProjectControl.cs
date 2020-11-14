using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectControl : UnitySingle<ProjectControl>
{
    // Start is called before the first frame update
    public Player player;
    AnimatorControl animatorControl;
    public int EnemyCount = 10;
    public static int EnemyInCount=0;
    public static int Money = 0;
    public int MaxIntrusionCount = 5;
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.Isdie == true)
            PlayerDeathDetection();
    }
    void PlayerDeathDetection()//主角死亡
    {
        
    }
    void EnemyIntrusionDetection()//敌人入侵地球检测
    { 
        
    }
    void VictoryDetection()
    { 
        
    }
    void FailDetection()
    {

    }
    void EnemyCreate()
    { 
        
    }


}
