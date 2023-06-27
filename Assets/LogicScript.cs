using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;
    public GameObject gameOverScreen;

    public void AddScore()
    {
        score += 1;
        scoreText.text = score.ToString();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
