using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public float startTime = 60.0f; // Tempo inicial em segundos
    public Color redColor = Color.red; // Cor dos números durante os últimos 30 segundos
    public string sceneName = "daniel"; // Nome da cena para a transição

    private Text minutesText;
    private Text secondsText;
    private Text millisecondsText;
    private float currentTime;

    private void Start()
    {
        minutesText = transform.Find("Minutes").GetComponent<Text>();
        secondsText = transform.Find("Seconds").GetComponent<Text>();
        millisecondsText = transform.Find("Milliseconds").GetComponent<Text>();

        currentTime = startTime;
    }

    private void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;

            // Atualiza os objetos de texto com os valores do timer
            minutesText.text = Mathf.Floor(currentTime / 60).ToString("00");
            secondsText.text = Mathf.Floor(currentTime % 60).ToString("00");
            millisecondsText.text = Mathf.Floor((currentTime * 100) % 100).ToString("00");

            // Muda a cor dos números para vermelho nos últimos 30 segundos
            if (currentTime <= 30)
            {
                minutesText.color = redColor;
                secondsText.color = redColor;
                millisecondsText.color = redColor;
            }
        }
        else
        {
            // Troca de cena quando o tempo acabar
            SceneManager.LoadScene(sceneName);
        }
    }
}
