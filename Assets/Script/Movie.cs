using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Movie : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    private RawImage rawImage;
    private int currentClipIndex;
   

    //设置相关文本和按钮参数以及视频列表
    public Text text_PlayOrPause;
    public Button button_PlayOrPause;
    public VideoClip[] videoClips;

    // Start is called before the first frame update
    void Start()
    {

        //获取场景中对应的组件
        videoPlayer = this.GetComponent<VideoPlayer>();
        rawImage = this.GetComponent<RawImage>();
        currentClipIndex = 0;
        //设置相关按钮监听事件
        button_PlayOrPause.onClick.AddListener(OnPlayOrPauseVideo);
    }

    // Update is called once per frame
    void Update()
    {
        //如果videoPlayer没有对应的视频texture，则返回
        if (videoPlayer.texture == null)
        {
            return;
        }
        //把VideoPlayerd的视频渲染到UGUI的RawImage
        rawImage.texture = videoPlayer.texture;
    }
    /// <summary>
    /// 播放和暂停当前视频
    /// </summary>
    private void OnPlayOrPauseVideo()
    {
        //判断视频播放情况，播放则暂停，暂停就播放，并更新相关文本
        if (videoPlayer.isPlaying == true)
        {
            videoPlayer.Pause();
            text_PlayOrPause.text = "播放";
        }
        else
        {
            videoPlayer.Play();
            text_PlayOrPause.text = "暂停";
        }
    }
}