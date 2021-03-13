using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scenery : MonoBehaviour
{
    public float tileSize;
    public int tileNum;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "tile")
        {
            Vector2 pos = collision.transform.position;
            pos.x += (tileSize * tileNum);
            collision.transform.position = pos;
        }
    }
}
