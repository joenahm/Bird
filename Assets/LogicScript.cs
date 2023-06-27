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
    public AudioSource bgm;
    public AudioSource goalSound;

    public void AddScore()
    {
        score += 1;
        scoreText.text = score.ToString();
        goalSound.Play();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        bgm.Stop();
    }
}
