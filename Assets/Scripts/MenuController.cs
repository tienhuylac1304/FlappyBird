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
    // Start is called before the first frame update
    void Start()
    {
        SetOnclick();
        ShowBestScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void SetOnclick()
    {
        btnPlay.onClick.AddListener(PlayButtonClick);
        btnSetting.onClick.AddListener(SettingButtonClick);
        btnExit.onClick.AddListener(ExitButtonClick);
    }
    void PlayButtonClick()
    {
        SceneManager.LoadScene(1);
        SceneManager.UnloadSceneAsync(0);
    }
    void SettingButtonClick()
    {
        settingPanel.SetActive(true);
    }
    void ExitButtonClick()
    {
        Application.Quit();
    }
    void ShowBestScore()
    {
        txtBestScore.text="Best Score: "+PlayerPrefs.GetInt("best_score").ToString();
    }
}
