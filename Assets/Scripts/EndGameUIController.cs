using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
        btnMenu.onClick.AddListener(ToMenu);
        btnExit.onClick.AddListener(ExitGame);
        btnRestart.onClick.AddListener(RestartGame);
    }
     void ToMenu()
    {
        SceneManager.LoadScene(0);
        SceneManager.UnloadSceneAsync(1);
    }
    void RestartGame()
    {

        SceneManager.LoadScene(1);
        gameObject.SetActive(false);
    }
    void ShowScore()
    {
        txtScore.text= "Your Score: "+ gameController.GetComponent<GameController>().Score().ToString()
                     + "\nBest Score: "+ PlayerPrefs.GetInt("best_score").ToString();
    }
    void ExitGame()
    {
        Application.Quit();
    }
}
