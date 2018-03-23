using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public int redScore;
    public int blueScore;

    public float timeLeft;
    public bool startTimer;

    public Text pointAText;
    public Text pointBText;
    public Text scoreText;
    public Text timerText;

    public TriggerPoint triggerPointA;
    public TriggerPoint triggerPointB;

    enum teamHolder { None, Red, Blue };
    teamHolder pointA = teamHolder.None;
    teamHolder pointB = teamHolder.None;



    void Start()
    {
        pointA = teamHolder.None;
        pointB = teamHolder.None;
        startTimer = false;
        timeLeft = 10f;
        timerText.text = timeLeft.ToString();
        redScore = 0;
        blueScore = 0;
        scoreText.text = "Red: " + redScore + " Blue: " + blueScore;
    }

    public void changePointABlue()
    {
        pointA = teamHolder.Blue;
        pointAText.text = "Point A: Blue";
        triggerPointA.blueColorChange();
        checkBothPoints();
    }

    public void changePointBBlue()
    {
        pointB = teamHolder.Blue;
        pointBText.text = "Point B: Blue";
        triggerPointB.blueColorChange();
        checkBothPoints();
    }

    public void changePointARed()
    {
        pointA = teamHolder.Red;
        pointAText.text = "Point A: Red";
        triggerPointA.redColorChange();
        checkBothPoints();
    }

    public void changePointBRed()
    {
        pointB = teamHolder.Red;
        pointBText.text = "Point B: Red";
        triggerPointB.redColorChange();
        checkBothPoints();
    }

    public void checkBothPoints()
    {
        if(pointA == pointB && pointA != 0)
        {
            startTimer = true;
        }
        else
        {
            resetTimer();
        }
    }
    public void endRound()
    {
        advanceScore();
        resetTimer();
        resetPoints();
        GameObject[] RedTeam = GameObject.FindGameObjectsWithTag("RedPlayer");
        foreach(GameObject player in RedTeam)
        {
            player.transform.position = new Vector3(0f, -8f, -111f);
        }
        GameObject[] BlueTeam = GameObject.FindGameObjectsWithTag("BluePlayer");
        foreach (GameObject player in BlueTeam)
        {
            player.transform.position = new Vector3(0f, -8f, 111f);
        }


    }

    public void advanceScore()
    {
        if (pointA == teamHolder.Red)
        {
            redScore++;
        }
        else
        {
            blueScore++;
        }
        scoreText.text = "Red: " + redScore + " Blue: " + blueScore;
    }

    public void resetTimer()
    {
        startTimer = false;
        timeLeft = 10f;
        timerText.text = timeLeft.ToString();
    }

    public void resetPoints()
    {
        triggerPointA.resetColor();
        pointAText.text = "Point B: None";
        pointA = teamHolder.None;
        triggerPointB.resetColor();
        pointBText.text = "Point B: None";
        pointB = teamHolder.None;
    }

    void Update()
    {
        if (startTimer)
        {
            timeLeft -= Time.deltaTime;
            timerText.text = timeLeft.ToString();
            if(timeLeft <= 0)
            {
                endRound();
            }
        }
    }

}

