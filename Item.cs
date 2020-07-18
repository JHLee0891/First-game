using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string type;
    Rigidbody2D rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        rigid.velocity = Vector2.down * 0.5f;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {   //#.Border For Item
        if (collision.gameObject.tag == "BorderBullet")
        {
            Destroy(gameObject);
        }
    }
}

