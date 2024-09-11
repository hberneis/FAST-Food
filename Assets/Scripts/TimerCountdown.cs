using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerCountdown : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI timer;
    public GameObject gameOverImg;
    
    public float timeRemaining = 5;
    
    void Start()
    {
        UpdateTime(timeRemaining);
        gameOverText.gameObject.SetActive(false);
    }
    
    void Update()
    {
        if(timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTime(timeRemaining);
        }
        else
        {
            UpdateTime(0);
            GameOver();
        }
    }
    public void UpdateTime(float timeLeft)
    {
        timer.text = "Time remaining: " + Mathf.FloorToInt(timeLeft);
    }
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        gameOverImg.SetActive(true);
    }
/*    public GameObject textDisplay;
    public int secondsLeft = 30;
    public bool takingAway = false;
    
    void Start()
    {
    Debug.Log("Timer started");
        textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
    }
    
    void Update()
    {
        if (takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }
    }
    
    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        Debug.Log("Courotine");
        textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
        Debug.Log("Courotine2");
        takingAway = false;
    }
    */
}
