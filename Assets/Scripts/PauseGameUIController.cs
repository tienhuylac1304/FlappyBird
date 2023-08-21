using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseGameUIController : MonoBehaviour
{
    bool isUnMusic;
    bool isMute;
    public Button btnMusic;
    public Button btnSound;
    public Button btnResume;
    public Button btnMenu;
    public Button btnExit;
    public Sprite imgMute;
    public Sprite imgSound;
    public Sprite imgMusic;
    public Sprite imgUnMusic;
    public GameObject gamePlayUIController;
    public GameObject audioController;
    // Start is called before the first frame update
    void Start()
    {
        AudioState();
        SetOnclick();
    }
     void SetOnclick()
    {
        btnExit.onClick.AddListener(GameExit);
        btnMenu.onClick.AddListener(ToMenu);
        btnResume.onClick.AddListener(Resume);
        btnMusic.onClick.AddListener(MusicButtonClick);
        btnSound.onClick.AddListener(SoundButtonClick);
    }
    void GameExit()
    {
        audioController.GetComponent<AudioController>().GetClickSound();
        Application.Quit();
    }
    void ToMenu()
    {
        AudioState();
        audioController.GetComponent<AudioController>().GetClickSound();
        SceneManager.LoadScene(0);
        SceneManager.UnloadSceneAsync(1);
    }
     void Resume()
    {
        SaveChange();
        audioController.GetComponent<AudioController>().GetClickSound();
        gamePlayUIController.GetComponent<GamePlayUIController>().UnPause();
        gameObject.SetActive(false );
        Time.timeScale = 1;
    }
    // Audio Setting
    void SoundButtonClick()
    {
        isMute=!isMute;
        AudioButtonImage(btnSound, imgMute, imgSound, isMute);
        audioController.GetComponent<AudioController>().SetTempSound(isMute);
    }
    void MusicButtonClick()
    {
        isUnMusic=!isUnMusic;
        AudioButtonImage(btnMusic, imgUnMusic, imgMusic, isUnMusic);
        audioController.GetComponent<AudioController>().GetClickSound();
        audioController.GetComponent<AudioController>().SetTempMusic(isUnMusic);
    }
    void AudioState()
    {
        //Music
        if (PlayerPrefs.GetString("isUnMusic") != "True")
        {
            isUnMusic = false;
        }
        else
        {
            isUnMusic = true;
        }
        AudioButtonImage(btnMusic, imgUnMusic, imgMusic, isUnMusic);
        //Sound
        if (PlayerPrefs.GetString("isMute") != "True")
        {
            isMute = false;
        }
        else
        {
            isMute = true;
        }
        AudioButtonImage(btnSound, imgMute, imgSound, isMute);
    }
    void SaveChange()
    {
        PlayerPrefs.SetString("isUnMusic", isUnMusic.ToString());
        PlayerPrefs.SetString("isMute", isMute.ToString());
    }
    void AudioButtonImage(Button btnAudio, Sprite imgUnAudio, Sprite imgAudio, bool isUnAudio)
    {
        if (isUnAudio)
        {
            btnAudio.GetComponent<Image>().sprite = imgUnAudio;
        }
        else
        {
            btnAudio.GetComponent<Image>().sprite = imgAudio;
        }
    }
}
