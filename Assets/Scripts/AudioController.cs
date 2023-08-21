using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource themeSong;
    public AudioSource click;
    public AudioSource fly;
    public AudioSource point;
    public AudioSource game_over;
    public AudioSource hit;
    // Start is called before the first frame update
    void Start()
    {
    }
    public void SetAudio()
    {
        //Music
        if (PlayerPrefs.GetString("isUnMusic").Equals("True"))
        {
            themeSong.mute = true;
            game_over.mute = true;
        }
        else
        {
            themeSong.mute=false;
            themeSong.Play();
            game_over.mute=false;

        }
        //Sound
        if (PlayerPrefs.GetString("isMute").Equals("True"))
        {
            click.mute = true;
            point.mute = true;
            fly.mute = true;
            hit.mute = true;
        }
        else
        {
            click.mute = false;
            click.Play();
            point.mute = false;
            fly.mute = false;
            hit.mute = false;
        }
    }
    public void SetTempMusic(bool isMute)
    {
        //Music
        if (isMute)
        {
            themeSong.mute=true;
        }
        else
        {
            themeSong.mute=false;
            themeSong.Play();
        }
       
    }
    public void SetTempSound(bool isUnsound)
    {
        //Sound
        if (isUnsound)
        {
            click.mute = true;
        }
        else
        {
            click.mute = false;
            click.Play();
        }
    }
    public void GetThemeMusic()
    {
        if (PlayerPrefs.GetString("isUnMusic").Equals("True"))
        {
            themeSong.mute=true;
        }
        else
        {
            themeSong.Play();
        }
    }
    public void GetGameOverMusic()
    {
        if (PlayerPrefs.GetString("isUnMusic").Equals("True"))
        {
            game_over.mute = true;
        }
        else
        {
            game_over.Play();
        }
    }
    public void GetClickSound()
    {
        if (PlayerPrefs.GetString("isMute").Equals("True"))
        {
            click.mute=true;
        }
        else
        {
            click.Play();
        }
    }
    public void GetFlySound()
    {
        if (PlayerPrefs.GetString("isMute").Equals("True"))
        {
            fly.mute=true;
        }
        else
        {
            fly.Play();
        }
    }
    public void GetPointSound()
    {
        if (PlayerPrefs.GetString("isMute").Equals("True"))
        {
            point.mute=true;
        }
        else
        {
            point.Play();
        }
    }
    public void GetHitSound()
    {
        if (PlayerPrefs.GetString("isMute").Equals("True"))
        {
            hit.mute=true;
        }
        else
        {
            hit.Play();
        }
    }
    public void StopThemeMusic()
    {
        themeSong.Stop();
    }
}
