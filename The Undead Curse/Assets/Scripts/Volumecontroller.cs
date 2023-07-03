using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volumecontroller : MonoBehaviour
{
    public float volumeIncrement = 0.1f;

    public void IncreaseVolume()
    {
        if (AudioListener.volume < 1f)
        {
            AudioListener.volume += volumeIncrement;
        }
    }

    public void DecreaseVolume()
    {
        if (AudioListener.volume > 0f)
        {
            AudioListener.volume -= volumeIncrement;
        }
    }
}
