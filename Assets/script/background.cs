using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    public Transform pointcm;
    public GameObject bgs;
    void Start()
    {

    }

    void Update()
    {
        if(transform.position.x<pointcm.position.x)
        {
            transform.position = new Vector2(transform.position.x+10f, transform.position.y);
            Instantiate(bgs, transform.position, Quaternion.identity);
        }
    }
}
