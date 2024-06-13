using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] int score;
    [SerializeField] private GameObject GameOverObj;
    [SerializeField] private GameObject startObj;

 
    void Start()
    {
        Time.timeScale = 0;
        startObj.SetActive(true);
    }

    public void StartButton()
    {
        Time.timeScale = 1;
        GameOverObj.SetActive(false);
        startObj.SetActive(false);
    }
    void Update()
    {

    }
    public void GameOver()
    {
        GameOverObj.SetActive(true);
        Time.timeScale = 0;
    }
    public void RestartButton()
    {
        SceneManager.LoadScene(0);
    }

    public void Scoring()
        {
            score++;
            scoreText.text = score.ToString();
        }
}
