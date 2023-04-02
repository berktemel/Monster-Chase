using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform player;
    private GameObject moon;

    private Vector3 tempPos;
    private Vector3 moonPos;

    private float moonX, moonY;

    [SerializeField]
    private float minX, maxX;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        moon = GameObject.FindWithTag("Moon");
        moonX = moon.transform.position.x;
        moonY = moon.transform.position.y;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(!player)
        {
            return;
        }

        tempPos = transform.position;
        tempPos.x = player.position.x;

        if(tempPos.x < minX)
        {
            tempPos.x = minX;
        }
        if(tempPos.x > maxX)
        {
            tempPos.x = maxX;
        }
        transform.position = tempPos;
        moonPos.x = transform.position.x + moonX;
        moonPos.y = transform.position.y + moonY;
        moon.transform.position = moonPos;
    }


}
