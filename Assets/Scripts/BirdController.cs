using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BirdController : MonoBehaviour
{
    GameObject obj;
    int flyPower;
    Animator animator;
    //public field
    public GameObject gameController;
    public GameObject gamePlayUIController;
    public GameObject audioController;
    // Start is called before the first frame update
    void Start()
    {

        obj = gameObject;
        animator = obj.GetComponent<Animator>();
        flyPower = 250;
        animator.SetBool("isDead", false);
        animator.SetFloat("flyPower", 0);

    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButtonDown(0)&& !gameController.GetComponent<GameController>().IsEndGame()&&!gamePlayUIController.GetComponent<GamePlayUIController>().IsPause())
        {
            obj.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(0, flyPower), ForceMode2D.Force);
            audioController.GetComponent<AudioController>().GetFlySound();
        }
        animator.SetFloat("flyPower", obj.GetComponent<Rigidbody2D>().velocity.y);
        
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
        animator.SetBool("isDead", true);
        Debug.Log(animator.GetBool("isDead"));
        Debug.Log(animator.GetFloat("flyPower"));
        gameController.GetComponent<GameController>().EndGame();
    }
}
