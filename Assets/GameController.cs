using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text ScoreText;
    public Text TimerText;
    // public int MatchTime = 120;
    // private float StartTime = 0;
    // private int Score = 0;

    // private bool MatchActive = false;
    // void Start()
    // {
    //     SetTimeDisplay(MatchTime);
    //     StartTime = TimerText.time;
    //     MatchActive = true;

    // }

    // public void IncrementScore()
    // {
    //     if (MatchActive)
    //     {
    //         Score++;
    //         ScoreText.text = "Score: " + Score.ToString();

    //     }
    // }

    // void Update()
    // {
    //     if (Timer.time - StartTime < MatchTime)
    //     {
    //         float ElapsedTime = Time.time - StartTime;
    //         SetTimeDisplay(MatchTime - ElapsedTime);
    //     }
    //     else
    //     {
    //         MatchActive = false;
    //         SetTimeDisplay(0);
    //         ScoreText.color = Color.red;
    //         TimerText.color = Color.red;
    //     }

    // }
    // private void SetTimeDisplay(float TimeDisplay)
    // {
    //     TimerText.text = "Time: " + GetTimeDisplay(TimeDisplay);
    // }

    // private string GetTimeDisplay(float TimetoShow)
    // {
    //     int SecondsToShow = Mathf.CeilToInt(TimetoShow);
    //     int Seconds = SecondsToShow % 60;
    //     string SecondsDisplay = (Seconds < 10) ? "0" + Seconds.ToString() : Seconds.ToString();
    //     int Minutes = (SecondsToShow - Seconds) / 60;
    //     return Minutes.ToString() + ":" + SecondsDisplay;
    // }
}