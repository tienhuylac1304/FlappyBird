using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameUIController : MonoBehaviour
{
    public Button btnRestart;
    public Button btnMenu;
    public Button btnExit;
    public Text txtScore;
    public GameObject gameController;
    // Start is called before the first frame update
    void Start()
    {
        SetOnclick();
        ShowScore();
    }
    void SetOnclick()
    {
        btnRestart.onClick.AddListener(RestartGame);
    }
    void RestartGame()
    {
        gameObject.SetActive(false);
        gameController.GetComponent<GameController>().Restartgame();
    }
    void ShowScore()
    {
        txtScore.text= "Your Score: "+ gameController.GetComponent<GameController>().Score().ToString()
                     + "\nBest Score: "+ PlayerPrefs.GetInt("best_score").ToString();
    }
}
