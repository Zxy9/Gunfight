using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanEnemy : MonoBehaviour
{
    int Price;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject enemytemp in GameObject.FindGameObjectsWithTag("enemy"))
        Destroy(enemytemp);
    }

    // Update is called once per frame
    void Update()
    {
       // Destroy(GameObject.FindGameObjectWithTag("Enemy"));
    }
}
