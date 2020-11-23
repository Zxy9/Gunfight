using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LoadingSlice : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider LoadSlider;
    public int LoadSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LoadSlider.value += LoadSpeed;
        if (LoadSlider.value >= 100)
        {
            Destroy(gameObject);
        }
    }

}
