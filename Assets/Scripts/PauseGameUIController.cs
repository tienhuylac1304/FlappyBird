using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGameUIController : MonoBehaviour
{
    public Button btnMusic;
    public Button btnSound;
    public Button btnResume;
    public Button btnMenu;
    public Button btnExit;
    // Start is called before the first frame update
    void Start()
    {
        SetOnclick();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void SetOnclick()
    {
        btnExit.onClick.AddListener(GameExit);
        btnMenu.onClick.AddListener(ToMenu);
        btnResume.onClick.AddListener(Resume);
    }
    void GameExit()
    {
        Application.Quit();
    }
    void ToMenu()
    {
        // log
        Debug.Log("To Menu");
    }
     void Resume()
    {
        gameObject.SetActive(false );
        Time.timeScale = 1;
    }

}
