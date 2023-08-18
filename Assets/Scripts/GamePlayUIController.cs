using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayUIController : MonoBehaviour
{
    private bool isPause;

    public Button btnPause;
    public Text txtScore;
    public GameObject pauseGameController;
    public GameObject gameController;
    // Start is called before the first frame update
    void Start()
    {
        isPause = false;
        btnPause.onClick.AddListener(PauseGame);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void UpdateScore(int score)
    {
        txtScore.text = "Score: " + score.ToString();
    }
    public void PauseGame()
    {
        if (!gameController.GetComponent<GameController>().IsEndGame())
        {
            isPause = true;
            Time.timeScale = 0;
            pauseGameController.SetActive(true);
        }
        else return;
    }
    public bool IsPause()
    {
        return isPause;
    }
    public void UnPause()
    {
        isPause = false;
    }
}
