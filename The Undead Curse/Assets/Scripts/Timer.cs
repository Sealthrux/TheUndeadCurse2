using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float TstartTime = 120.0f; // Tempo inicial em segundos
    public Color redColor = Color.red; // Cor dos números durante os últimos 30 segundos
    public GameObject DeathMenu;

    public TMP_Text TminutesText;
    public TMP_Text TsecondsText;
    public float TcurrentTime;

    public void Start()
    {
        TminutesText = transform.Find("Minutes").GetComponent<TMP_Text>();
        TsecondsText = transform.Find("Seconds").GetComponent<TMP_Text>();

        TcurrentTime = TstartTime;
    }

    public void Update()
    {
        if (TcurrentTime > 0)
        {
            TcurrentTime -= Time.deltaTime;

            // Atualiza os objetos de texto com os valores do timer
            TminutesText.text = Mathf.Floor(TcurrentTime / 60).ToString("0");
            TsecondsText.text = Mathf.Floor(TcurrentTime % 60).ToString("00");
            // Muda a cor dos números para vermelho nos últimos 30 segundos
            if (TcurrentTime <= 30)
            {
                TminutesText.color = redColor;
                TsecondsText.color = redColor;            }
        }
        else
        {
            DeathMenu.SetActive(true);
        }
    }
}