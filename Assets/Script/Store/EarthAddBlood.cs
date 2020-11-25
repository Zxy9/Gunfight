using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthAddBlood : MonoBehaviour
{
    // Start is called before the first frame update
    int Price = 999;
    void Start()
    {
        
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GO()
    {
        if (ProjectControl.Money < Price)
        {
            Debug.Log("金钱不足");
        }
        else {
            if ((ProjectControl.EnemyInCount < 10) && (ProjectControl.EnemyInCount >= 0))
                ProjectControl.EnemyInCount = 0;
            if (ProjectControl.EnemyInCount >= 10)
                ProjectControl.EnemyInCount -= 10;
        }
    }
}
