using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class appManager : MonoBehaviour
{
    public UnityEngine.Events.UnityEvent gameWon;
    public UnityEngine.Events.UnityEvent gameLost;
    public bool gameStarted = false;
    public bool resetTriggered = false;
    public string difficulty = "Medium";
    public int turtlesKilled = 0;
    public int goal = 10;
    public int livesLeft = 3;
    public GameObject[] spawnPoints;
    TextMeshPro turtlesKilledString;
    TextMeshPro livesLeftString;
    TextMeshPro difficultyString;

    void Start()
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            spawnPoints[i].SetActive(false);
        }
        turtlesKilledString = GameObject.Find("TurtlesKilled").GetComponent<TextMeshPro>();
        livesLeftString = GameObject.Find("LivesLeft").GetComponent<TextMeshPro>();
        difficultyString = GameObject.Find("currentDifficulty").GetComponent<TextMeshPro>();
    }

    void Update()
    {
        turtlesKilledString.text = "Turtles Neutralized: " + turtlesKilled + " out of " + goal;
        livesLeftString.text = "Lives Left: " + livesLeft;
        if (turtlesKilled == goal)
        {
            gameWon.Invoke();
        }
        else if(livesLeft == 0)
        {
            gameLost.Invoke();
        }
    }

    public void SetDifficulty(string userDifficulty)
    {
        if (gameStarted == false)
        {
            difficulty = userDifficulty;
            if (difficulty == "Easy")
            {
                livesLeft = 5;
                goal = 10;
                difficultyString.text = "Easy";
            }
            else if (difficulty == "Medium")
            {
                livesLeft = 3;
                goal = 20;
                difficultyString.text = "Medium";
            }
            else if (difficulty == "Hard")
            {
                livesLeft = 1;
                goal = 30;
                difficultyString.text = "Hard";
            }
        }
    }

    public void startGame()
    {
        Debug.Log("DIFFICULTY = " + difficulty);
        if (gameStarted == false)
        {
            switch (difficulty)
            {
                case "Easy":
                    spawnPoints[2].SetActive(true);
                    break;
                case "Medium":
                    Debug.Log("WORKS");
                    spawnPoints[0].SetActive(true);
                    spawnPoints[2].SetActive(true);
                    spawnPoints[5].SetActive(true);
                    break;
                case "Hard":
                    for (int i = 0; i < spawnPoints.Length; i++)
                    {
                        spawnPoints[i].SetActive(true);
                    }
                    break;
                default:
                    Debug.Log("Invalid Difficulty");
                    break;
            }
        }
        gameStarted = true;
    }

}
