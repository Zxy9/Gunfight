using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthAddBlood : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if ((ProjectControl.EnemyInCount < 10) && (ProjectControl.EnemyInCount >= 0))
            ProjectControl.EnemyInCount = 0;
        if (ProjectControl.EnemyInCount>=10)
        ProjectControl.EnemyInCount-=10;
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
