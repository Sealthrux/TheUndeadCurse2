using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class CutsceneInicial : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string MainScene;

    void Start()
    {
        videoPlayer.loopPointReached += NoFinalDoVideo;
    }

    void NoFinalDoVideo(VideoPlayer vp)
    {
        SceneManager.LoadScene(MainScene);
    }
}
