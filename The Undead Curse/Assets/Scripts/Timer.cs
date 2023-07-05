using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float TstartTime = 120.0f; // Tempo inicial em segundos
    public Color redColor = Color.red; // Cor dos n�meros durante os �ltimos 30 segundos

    public TMP_Text TminutesText;
    public TMP_Text TsecondsText;
    public float TcurrentTime;
    public GameObject TimedMessage;

    public void Start()
    {
        TminutesText = transform.Find("Minutes").GetComponent<TMP_Text>();
        TsecondsText = transform.Find("Seconds").GetComponent<TMP_Text>();

    }

    public void Update()
    {
        if (TcurrentTime > 0)
        {
            TcurrentTime -= Time.deltaTime;

            // Atualiza os objetos de texto com os valores do timer
            TminutesText.text = Mathf.Floor(TcurrentTime / 60).ToString("0");
            TsecondsText.text = Mathf.Floor(TcurrentTime % 60).ToString("00");
            // Muda a cor dos n�meros para vermelho nos �ltimos 30 segundos
            if (TcurrentTime <= TstartTime)
            {
                TminutesText.color = redColor;
                TsecondsText.color = redColor;            
            }

            if (TcurrentTime <= 0)
            {
                TcurrentTime = 0;
            }

            if (TcurrentTime <= 120)
            {
                TimedMessage.SetActive(true);
            }
        }
        
    }

    public bool TimerCheck()
    {
        if (TcurrentTime <= 60)
        {
            return true;
        }
        else { return false; }
    }

    public bool TimerDeath()
    {
        if (TcurrentTime <= 0) 
        {
            return true;
           
        }
        else { return false; }
    }
}