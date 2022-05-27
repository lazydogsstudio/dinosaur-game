using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public Text score;
    public GameObject gameOverPanel;
    public bool isGameOver;
    int totalScore = 0;



    void Start()
    {
        StartCoroutine(updateScore());
    }

    void Update()
    {
        score.text = totalScore.ToString();

        if (isGameOver)
        {
            gameOverPanel.SetActive(true);
        }
    }


    IEnumerator updateScore()
    {
        while (!isGameOver)
        {
            yield return new WaitForSeconds(1f);
            totalScore++;
        }
    }

    public void restartGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
