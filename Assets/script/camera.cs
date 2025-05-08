using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform bird,bird2,col;
    Vector2 set;
    int bi = 0;

    void Start()
    {
        set=transform.position-bird.position;
        bi = PlayerPrefs.GetInt("bi", 0);

    }

    void Update()
    {
        transform.position = new Vector3(col.position.x + set.x, transform.position.y, transform.position.z);

        if (bi==0)
        {
            transform.position = new Vector3(bird.position.x + set.x, transform.position.y, transform.position.z);
        }
        if (bi == 1)
        {
            transform.position = new Vector3(bird2.position.x + set.x, transform.position.y, transform.position.z);
        }

    }
}
