using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float moveSpeed = 0f;
    Vector2 startPos;
    Vector2 endPos;
    float swipelength;
    bool isMove = false;
    
    void Start()
    {
       
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isMove.Equals(false))
        {
            startPos = Input.mousePosition;
        }

        if(Input.GetMouseButtonUp(0) && isMove.Equals(false)) {
            endPos = Input.mousePosition;
            swipelength = Mathf.Abs(endPos.x - startPos.x);
            moveSpeed = swipelength/1000;
            isMove = true;
            GetComponent<AudioSource>().Play();
        }

        
        transform.Translate(moveSpeed,0,0);

        moveSpeed *= 0.97f;

        if(moveSpeed < 0.01f)
        {
            moveSpeed = 0f;
       
        }

        if (Input.GetMouseButton(1) && moveSpeed == 0)
        {   
            transform.position = new Vector3(-7f, -3.7f, 0f);
            isMove = false;
        }
    }
}
