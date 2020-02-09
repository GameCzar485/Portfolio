using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private float startTime;
    public TextMeshProUGUI timerText;
    public int endTime;

    private void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        int min = (int)t/60;

        if (min < endTime)
        {
            timerText.text = "TIME: " + minutes + ":" + seconds;
        }
        else
        {
            timerText.text = "TIME: " + endTime + ":" + "00";
        }
    }
}
