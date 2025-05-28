using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Text distanceText;
    public GameObject car;
    public GameObject flag;
    float distance;
    void Start()
    {
        
    }

    void Update()
    {
        distance = flag.transform.position.x - car.transform.position.x;
        
        if (distance >= 0 )
        {
            distanceText.text = "목표 지점까지 : " + distance.ToString("F2") + "m";
        }
        else
        {
            distanceText.text = "Game Over";
        }
    }
}
