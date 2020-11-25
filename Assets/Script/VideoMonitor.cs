using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class VideoMonitor : MonoBehaviour
{
    public GameObject next;
    // Start is called before the first frame update
    void Start()
    {
         VideoPlayer VideoPlayer = GetComponent<VideoPlayer>();
        VideoPlayer.loopPointReached += ReachedMethod;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ReachedMethod(VideoPlayer videoPlayer)
    {
        Debug.Log("视频播放完成");
        next.SetActive(true);
    }

}
