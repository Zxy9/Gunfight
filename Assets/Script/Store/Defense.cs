
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Defense : MonoBehaviour
{
    // Start is called before the first frame update
    int Price;//道具的价钱
    int PlayerBlood;//中间值不必设置
    void Start()
    {
        Destroy(this.gameObject, 15);
        PlayerBlood = GameObject.Find("VR").GetComponent<Player>().Blood;

    }

    // Update is called once per frame
    void Update()
    {

        GameObject.Find("VR").GetComponent<Player>().Blood = PlayerBlood;

    }
   // public  void Function();
    
    //IEnumerator Defense()
    //{
    //    yield return new WaitForSeconds(10);
    //    Destroy(this.gameObject, 15);
    //}
    

}
