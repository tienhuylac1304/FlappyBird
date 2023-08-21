using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public Button btnPlay;
    public Button btnSetting;
    public Button btnExit;
    public Text txtBestScore;
    public GameObject settingPanel;
    public GameObject audioController;
    // Start is called before the first frame update
    void Start()
    {
        SetOnclick();
        ShowBestScore();
        audioController.GetComponent<AudioController>().GetThemeMusic();
    }
     void SetOnclick()
    {
        btnPlay.onClick.AddListener(PlayButtonClick);
        btnSetting.onClick.AddListener(SettingButtonClick);
        btnExit.onClick.AddListener(ExitButtonClick);
    }
    void PlayButtonClick()
    {
        audioController.GetComponent<AudioController>().StopThemeMusic();
        SceneManager.LoadScene(1);
        SceneManager.UnloadSceneAsync(0);
    }
    void SettingButtonClick()
    {
        audioController.GetComponent<AudioController>().GetClickSound();
        settingPanel.SetActive(true);
    }
    void ExitButtonClick()
    {
        audioController.GetComponent<AudioController>().GetClickSound();
        Application.Quit();
    }
    void ShowBestScore()
    {
        txtBestScore.text="Best Score: "+PlayerPrefs.GetInt("best_score").ToString();
    }
}
