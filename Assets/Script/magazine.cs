using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magazine : MonoBehaviour
{
    // Start is called before the first frame update
    public Player player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.transform.tag == "Hand")
        {
            Debug.Log("222");
            player.LeftGun[player.GunNumber].gameObject.SetActive(false);
            player.RightGun[player.GunNumber].gameObject.SetActive(false);
            player.GunNumber++;
            if (player.GunNumber >= player.LeftGun.Length)
            {
                player.GunNumber = 0;
            }
            player.LeftGun[player.GunNumber].gameObject.SetActive(true);
            player.RightGun[player.GunNumber].gameObject.SetActive(true);

        }
    }
}
