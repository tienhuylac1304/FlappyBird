using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BirdController : MonoBehaviour
{
    GameObject obj;
    int flyPower;
    //public field
    public GameObject gameController;
    public GameObject gamePlayUIController;
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        flyPower = 250;
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButtonDown(0)&& !gameController.GetComponent<GameController>().IsEndGame()&&!gamePlayUIController.GetComponent<GamePlayUIController>().IsPause())
        {
            obj.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(0, flyPower), ForceMode2D.Force);

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag== "point_line")
        {
            gameController.GetComponent<GameController>().AddScore();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameController.GetComponent<GameController>().EndGame();
    }
}
