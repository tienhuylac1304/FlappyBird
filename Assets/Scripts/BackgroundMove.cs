using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    GameObject obj;
    int moveSpeed;
    Vector3 oldPos;
    float backgroundLimited;
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        moveSpeed = 3;
        oldPos= transform.position;
        backgroundLimited =(float) -17.93;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(obj.transform.position.x <= backgroundLimited)
        {
            obj.transform.position = oldPos;
        }
        else
            obj.transform.position = new Vector3(obj.transform.position.x - Time.deltaTime * moveSpeed, obj.transform.position.y, obj.transform.position.z);
    }
}
