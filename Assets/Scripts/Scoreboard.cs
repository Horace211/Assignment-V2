using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour
{

    //it will create scoreboard instace so you can access the variables from this script to any other script
    public static Scoreboard instance;



    public Text p1ScoreText;
    public Text p2ScoreText;

    public int p1Score;
    public int p2Score;

    // Use this for initialization
    void Start()
    {

        instance = this;
        p1Score = p2Score = 0;

    }

    // Update is called once per frame
    void Update()
    {



    }

    public void P2Scored()
    {
        p2Score += 1;
        //It will take p1 int and convert into string and it will write into the text
        p2ScoreText.text = p2Score.ToString();

        if (p2Score > 9)
        {
            SceneManager.LoadScene(5);
        }

    }
    public void P1Scored()
    {
        p1Score += 1;
        //It will take p1 int and convert into string and it will write into the text
        p1ScoreText.text = p1Score.ToString();

        if (p1Score > 9)
        {
            SceneManager.LoadScene(4);
        }
    }
}
