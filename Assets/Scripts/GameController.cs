using UnityEngine;

public class GameController : MonoBehaviour
{

    bool isEndGame;
    int score;
    //public field
    public GameObject gamePlayUIController;
    public GameObject endGameUIController;
    public GameObject audioController;


    // Start is called before the first frame update
    void Start()
    {
        isEndGame = false;
        score = 0;
        Time.timeScale = 0;
        audioController.GetComponent<AudioController>().GetThemeMusic();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)&&!isEndGame&&!gamePlayUIController.GetComponent<GamePlayUIController>().IsPause())
        {
           Time.timeScale = 1;
        }
    }

    public bool IsEndGame()
    {
        return isEndGame;
    }
    public void AddScore()
    {
        score++;
        gamePlayUIController.GetComponent<GamePlayUIController>().UpdateScore(score);
        audioController.GetComponent<AudioController>().GetPointSound();

    }
    public void EndGame()
    {
        SetBestScore();
        audioController.GetComponent<AudioController>().StopThemeMusic();
        audioController.GetComponent<AudioController>().GetHitSound();
        audioController.GetComponent<AudioController>().GetGameOverMusic();
        isEndGame = true;
        Time.timeScale = 0;
        endGameUIController.SetActive(true);

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
