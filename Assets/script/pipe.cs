using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    public Transform po;
    public GameObject pi;
    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.x < po.position.x)
        {
            transform.position = new Vector2(transform.position.x + 8f, transform.position.y);
            Vector2 posX = new Vector2(transform.position.x, (Random.Range(-3f, 3f)));
            Instantiate(pi, posX, Quaternion.identity);
        }

    }
    
}
