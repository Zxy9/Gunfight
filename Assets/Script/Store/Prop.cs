using Boo.Lang;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Prop : MonoBehaviour
{
    // Start is called before the first frame update
    int Price;//道具的价钱
    int PlayerBlood;//中间值不必设置
    void Start()
    {
        Destroy(this.gameObject, 15);
        PlayerBlood = GetComponent<Player>().Blood;
    }

    // Update is called once per frame
    void Update()
    {
       
        GetComponent<Player>().Blood = PlayerBlood;

    }
    public abstract void Function();
    
    //IEnumerator Defense()
    //{
    //    yield return new WaitForSeconds(10);
    //    Destroy(this.gameObject, 15);
    //}
    

}
