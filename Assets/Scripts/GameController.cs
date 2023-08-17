using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    bool isEndGame;
    int score;
    //public field
    public GameObject gamePlayUIController;
    public GameObject endGameUIController;


    // Start is called before the first frame update
    void Start()
    {
        isEndGame = false;
        score = 0;
    }

    public bool IsEndGame()
    {
        return isEndGame;
    }
    public void AddScore()
    {
        score++;
        gamePlayUIController.GetComponent<GamePlayUIController>().UpdateScore(score);
    }
    public void EndGame()
    {
        SetBestScore();
        isEndGame = true;
        Time.timeScale = 0;
        endGameUIController.SetActive(true);

    }
    public void Restartgame()
    {
        SceneManager.LoadScene(0);
    }
    public int Score()
    {
        return score;
    }
    void SetBestScore()
    {
        if(PlayerPrefs.GetInt("best_score")<=score)
        {
            PlayerPrefs.SetInt("best_score", score);
        }
    }
}
