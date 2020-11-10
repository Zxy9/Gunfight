using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectControl : MonoBehaviour
{
    // Start is called before the first frame update
    Player player;
    AnimatorControl animatorControl;
    int EnemyCount = 10;
    void Start()
    {
        player = GetComponent<Player>();
        animatorControl = GetComponent<AnimatorControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void PlayerDeathDetection()//主角死亡检测
    {
        if (player.Blood <= 0)
        {
            animatorControl.Play();
        }
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
