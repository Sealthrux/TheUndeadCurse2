using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlay : MonoBehaviour
{
    public static MusicPlay instance;


    private void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

       
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Menu")
        {
            MusicPlay.instance.GetComponent<AudioSource>().Pause();
        }
        if (SceneManager.GetActiveScene().name == "CutsceneInicial")
        {
            MusicPlay.instance.GetComponent<AudioSource>().Pause();
        }
        if (SceneManager.GetActiveScene().name == "MainScene")
        {
            MusicPlay.instance.GetComponent<AudioSource>().UnPause();
        }
    }
}
