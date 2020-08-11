using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerScript : MonoBehaviour
{
    VideoPlayer videoWeb;
    public int videoNumber;

    // Start is called before the first frame update
    void Awake()
    {
        string videoName;
        switch (videoNumber)
        {
            case 0:
                videoName = "/4.mp4";
                break;
            case 1:
                videoName = "/13.mp4";
                break;
            case 2:
                videoName = "/18.mp4";
                break;
            case 3:
                videoName = "/28.mp4";
                break;
            case 4:
                videoName = "/28-1.mp4";
                break;
            case 5:
                videoName = "/4.mp4";
                break;
            //case 6:
            //    videoName = "/Video6.mp4";
            //    break;
            case 7:
                videoName = "/18.mp4";
                break;
            default:
                videoName = "/4.mp4";
                break;
        }
        videoWeb = GetComponent<VideoPlayer>();
        videoWeb.url = Application.streamingAssetsPath + videoName;
        videoWeb.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
