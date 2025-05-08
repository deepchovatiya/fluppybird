using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coll : MonoBehaviour
{
    Rigidbody2D a;
    float speed = 4f;
    void Start()
    {
        a= GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        a.velocity = new Vector2( speed, a.velocity.y);
        if(transform.position.x!=0)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 0), speed);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="pipe")
        {
            Destroy(collision.gameObject);
        }
    }
}
