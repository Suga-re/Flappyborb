using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;
    public GameObject gameOverScreen;

    [ContextMenu("increase score")]
    public void addScore(int scoreToAdd, bool birdIsAlive)
    {
        if (birdIsAlive)
        {
            score += scoreToAdd;
            scoreText.text = score.ToString();
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        
    }

}
