using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class QuizOneCodingChallenge : MonoBehaviour
{
    public int Score = 0;
    public string PlayerName = "Dominic";
    public int Health = 100;

    // Start is called before the first frame update
    void Start()
    {
        IncreaseScore();
        DecreaseHealth();
    }

    // Update is called once per frame
    void Update()
    {
        PrintPlayerName();
    }

    private void IncreaseScore()
    {
        Score++;
    }

    public void PrintPlayerName()
    {
        Debug.Log(PlayerName);
    }

    private void DecreaseHealth()
    {
        Health--;
    }
}
