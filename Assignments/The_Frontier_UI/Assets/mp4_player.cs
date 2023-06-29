using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class mp4_player : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        videoPlayer.url = System.IO.Path.Combine(Application.streamingAssetsPath, "0001_1.mp4");
    }
}
