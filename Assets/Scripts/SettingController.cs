using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingController : MonoBehaviour
{
    bool isMute;
    bool isUnMusic;

    public Button btnSound;
    public Button btnMusic;
    public Button btnAccept;
    public Button btnCancel;

    public Sprite imgMute;
    public Sprite imgSound;
    public Sprite imgMusic;
    public Sprite imgUnMusic;
    // Start is called before the first frame update
    void Start()
    {
        AudioState();
        SetOnclick();
    }
    void SetOnclick()
    {
        btnAccept.onClick.AddListener(AcceptButtonClick);
        btnCancel.onClick.AddListener(CancelButtonClick);
        btnMusic.onClick.AddListener(MusicButtonClick);
        btnSound.onClick.AddListener(SoundButtonClick);
    }
    void AcceptButtonClick()
    {
        SaveChange();
        gameObject.SetActive(false);
    }
    void CancelButtonClick()
    {
        AudioState();
        gameObject.SetActive(false);
    }
    void SoundButtonClick()
    {
        isMute = !isMute;
        AudioButtonImage(btnSound, imgMute, imgSound, isMute);
    }
    void MusicButtonClick()
    {
        isUnMusic = !isUnMusic;
        AudioButtonImage(btnMusic, imgUnMusic, imgMusic, isUnMusic);
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
