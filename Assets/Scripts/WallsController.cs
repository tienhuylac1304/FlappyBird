using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsController : MonoBehaviour
{
    GameObject obj;
    float refreshPosX;
    float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        refreshPosX = 10;
        moveSpeed = 3;
        obj.transform.position = new Vector3(transform.position.x, Random.Range(-2,2), transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.position = new Vector3(obj.transform.position.x - Time.deltaTime * moveSpeed, obj.transform.position.y, obj.transform.position.z);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag.Equals("refresh_wall_line"))
        {
            obj.transform.position = new Vector3(refreshPosX, Random.Range(-2, 2), 10);
        }
    }
}
