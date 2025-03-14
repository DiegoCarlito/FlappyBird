using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicManager : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    [ContextMenu("Increase Score")]
    void addScore()
    {
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
    }
}
