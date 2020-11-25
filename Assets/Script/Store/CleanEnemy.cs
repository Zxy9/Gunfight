using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanEnemy : MonoBehaviour
{
    int Price=999;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // Destroy(GameObject.FindGameObjectWithTag("Enemy"));
    }
    public void GO()
    {
        if (ProjectControl.Money < Price)
        {
            Debug.Log("金钱不足");
        }
        else
        {
            foreach (GameObject enemytemp in GameObject.FindGameObjectsWithTag("enemy"))
                enemytemp.GetComponent<Enemy>().blood=0;
        }
    }
}
