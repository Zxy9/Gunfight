using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountUp : MonoBehaviour
{
    // Start is called before the first frame update
    public ProjectControl projectControl;
    public Text counttext;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddCount()
    {
        for (int count = 0; count <= projectControl.EnemyCount;count++)
        {
            counttext.text = count.ToString();
        }
        
    }
}
